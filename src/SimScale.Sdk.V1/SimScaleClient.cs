using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1;

public class SimScaleClient : IDisposable
{
    private readonly HttpClient _http;
    private readonly int _maxRetries;
    private readonly double _retryBackoff;
    private readonly double _retryAfterCap;
    private readonly RateLimiter _rateLimiter;

    private static readonly HashSet<int> RetriableStatuses = [408, 429, 500, 502, 503, 504];
    private static readonly HashSet<HttpMethod> IdempotentMethods =
        [HttpMethod.Get, HttpMethod.Head, HttpMethod.Options, HttpMethod.Put, HttpMethod.Delete];

    internal static readonly string SdkVersion =
        typeof(SimScaleClient).Assembly.GetName().Version?.ToString(3) ?? "0.0.0";

    internal static readonly string UserAgent = $"simscale-sdk-csharp/{SdkVersion}";

    internal static readonly JsonSerializerOptions JsonOptions = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters = { new NullableGuidConverter() },
    };

    /// <summary>Handles null JSON values for non-nullable Guid properties by returning Guid.Empty.</summary>
    private class NullableGuidConverter : JsonConverter<Guid>
    {
        public override Guid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return Guid.Empty;
            return reader.GetGuid();
        }

        public override void Write(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }

    /// <param name="apiKey">SimScale API key sent as the X-API-KEY header.</param>
    /// <param name="serverUrl">Base URL for the API (scheme + host, no trailing path).</param>
    /// <param name="timeout">Per-request read timeout, seconds (default 60). Lower it for faster failure on quick calls.</param>
    /// <param name="maxRetries">Retries on network errors / 5xx (idempotent) and 429 (any method).</param>
    /// <param name="retryBackoff">Base for exponential backoff, seconds.</param>
    /// <param name="retryAfterCap">Upper bound on a server Retry-After sleep, seconds.</param>
    /// <param name="maxConnectionsPerServer">Connection-pool cap.</param>
    /// <param name="maxRequestsPerSecond">Optional client-side rate limiter (paces outbound requests); null disables it.</param>
    public SimScaleClient(
        string apiKey,
        string serverUrl,
        double timeout = 60.0,
        int maxRetries = 5,
        double retryBackoff = 0.2,
        double retryAfterCap = 60.0,
        int maxConnectionsPerServer = 100,
        double? maxRequestsPerSecond = null)
    {
        var handler = new SocketsHttpHandler
        {
            MaxConnectionsPerServer = maxConnectionsPerServer,
            PooledConnectionLifetime = TimeSpan.FromMinutes(5),
        };
        _http = new HttpClient(handler, disposeHandler: true)
        {
            BaseAddress = new Uri(serverUrl.TrimEnd('/') + "/"),
            Timeout = TimeSpan.FromSeconds(timeout),
        };
        _http.DefaultRequestHeaders.Add("X-API-KEY", apiKey);
        _http.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgent);
        _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _maxRetries = maxRetries;
        _retryBackoff = retryBackoff;
        _retryAfterCap = retryAfterCap;
        _rateLimiter = new RateLimiter(maxRequestsPerSecond);
    }

    public T Request<T>(HttpMethod method, string path, object? body = null,
        Stream? binaryBody = null,
        string? contentType = null,
        Dictionary<string, object?>? queryParams = null)
    {
        using var response = SendRequest(method, path, body, binaryBody, contentType, queryParams);
        var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        // 204, or any 2xx with an empty body, carries no value to deserialize. Endpoints that
        // document a 204 alongside a body generate a nullable return type for exactly this case.
        if (string.IsNullOrEmpty(json))
            return default!;
        return JsonSerializer.Deserialize<T>(json, JsonOptions)!;
    }

    public void RequestVoid(HttpMethod method, string path, object? body = null,
        Stream? binaryBody = null,
        string? contentType = null,
        Dictionary<string, object?>? queryParams = null)
    {
        using var response = SendRequest(method, path, body, binaryBody, contentType, queryParams);
    }

    public byte[] RequestBytes(HttpMethod method, string path, object? body = null,
        Stream? binaryBody = null,
        string? contentType = null,
        Dictionary<string, object?>? queryParams = null)
    {
        using var response = SendRequest(method, path, body, binaryBody, contentType, queryParams);
        return response.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
    }

    public PaginatedResponse<T> RequestPaginated<T>(HttpMethod method, string path, object? body = null,
        Stream? binaryBody = null,
        string? contentType = null,
        Dictionary<string, object?>? queryParams = null)
    {
        using var response = SendRequest(method, path, body, binaryBody, contentType, queryParams);
        var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        using var doc = JsonDocument.Parse(json);
        return new PaginatedResponse<T>(doc.RootElement, JsonOptions);
    }

    private HttpResponseMessage SendRequest(HttpMethod method, string path, object? body,
        Stream? binaryBody,
        string? contentType,
        Dictionary<string, object?>? queryParams)
    {
        var url = path.TrimStart('/');

        if (queryParams != null)
        {
            var pairs = new List<string>();
            foreach (var kv in queryParams)
            {
                if (kv.Value == null) continue;
                var key = Uri.EscapeDataString(kv.Key);
                if (kv.Value is System.Collections.IEnumerable enumerable and not string)
                    foreach (var item in enumerable)
                        pairs.Add($"{key}={Uri.EscapeDataString(item?.ToString() ?? "")}");
                else
                    pairs.Add($"{key}={Uri.EscapeDataString(kv.Value.ToString()!)}");
            }
            if (pairs.Count > 0)
                url += "?" + string.Join("&", pairs);
        }

        string? jsonBody = null;
        if (body != null)
            jsonBody = JsonSerializer.Serialize(body, body.GetType(), JsonOptions);
        if (jsonBody != null && binaryBody != null)
            throw new ArgumentException("body and binaryBody cannot be used together");

        var response = SendWithRetry(method, url, () =>
        {
            if (binaryBody != null && binaryBody.CanSeek)
                binaryBody.Position = 0;
            var request = new HttpRequestMessage(method, url);
            if (jsonBody != null)
                request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            if (binaryBody != null)
            {
                request.Content = new StreamContent(binaryBody);
                if (!string.IsNullOrWhiteSpace(contentType))
                    request.Content.Headers.ContentType = new MediaTypeHeaderValue(contentType);
            }
            return _http.Send(request);
        });
        if (!response.IsSuccessStatusCode)
        {
            var responseBody = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            response.Dispose();
            throw new SimScaleAPIError((int)response.StatusCode, responseBody, response.RequestMessage?.RequestUri?.ToString());
        }

        return response;
    }

    /// <summary>
    /// Invoke <paramref name="send"/> with retries on transient failures.
    /// Retries network errors and 5xx responses for idempotent methods, and 429
    /// regardless of method. Honors Retry-After on 429 when present, capped at
    /// retryAfterCap. Gated by the client-side rate limiter. Fails loud: a client
    /// timeout that exhausts retries is thrown as SimScaleTimeoutException with
    /// context (never swallowed), and every retry is traced so a throttled/slow
    /// call is visible rather than looking like a hang.
    /// </summary>
    private HttpResponseMessage SendWithRetry(HttpMethod method, string url, Func<HttpResponseMessage> send)
    {
        var start = Stopwatch.GetTimestamp();
        Exception? lastExc = null;
        for (var attempt = 0; attempt <= _maxRetries; attempt++)
        {
            _rateLimiter.Acquire();
            HttpResponseMessage resp;
            try
            {
                resp = send();
            }
            catch (Exception e) when (e is HttpRequestException or TaskCanceledException)
            {
                lastExc = e;
                if (attempt >= _maxRetries || !IdempotentMethods.Contains(method))
                {
                    // A TaskCanceledException here is an HttpClient.Timeout (no external
                    // cancellation token is used) — surface it as a typed, contextful
                    // error rather than a bare cancellation that reads like a hang.
                    if (e is TaskCanceledException)
                    {
                        var elapsed = (Stopwatch.GetTimestamp() - start) / (double)Stopwatch.Frequency;
                        // Report the absolute URL (like the Python SDK and SimScaleAPIError),
                        // not the relative request path.
                        var absoluteUrl = _http.BaseAddress is { } baseAddr ? new Uri(baseAddr, url).ToString() : url;
                        throw new SimScaleTimeoutException(method.Method, absoluteUrl, elapsed, attempt + 1, e);
                    }
                    throw;
                }
                var backoff = BackoffDelay(attempt);
                Trace.TraceWarning($"{method.Method} {url} failed ({e.GetType().Name}); retry {attempt + 1}/{_maxRetries} in {backoff.TotalSeconds:0.0}s");
                Thread.Sleep(backoff);
                continue;
            }

            var status = (int)resp.StatusCode;
            var retryStatus = status == 429
                || (RetriableStatuses.Contains(status) && IdempotentMethods.Contains(method));
            if (retryStatus && attempt < _maxRetries)
            {
                var delay = RetryDelay(attempt, resp);
                resp.Dispose();
                Trace.TraceWarning($"{method.Method} {url} got HTTP {status}; retry {attempt + 1}/{_maxRetries} in {delay.TotalSeconds:0.0}s");
                Thread.Sleep(delay);
                continue;
            }
            return resp;
        }
        throw lastExc ?? new InvalidOperationException("retry loop exited unexpectedly");
    }

    private TimeSpan RetryDelay(int attempt, HttpResponseMessage resp)
    {
        if ((int)resp.StatusCode == 429 && resp.Headers.RetryAfter?.Delta is { } delta)
        {
            // Cap the server-provided delay so a large Retry-After doesn't stall
            // the caller for minutes and read as a hang.
            var cap = TimeSpan.FromSeconds(_retryAfterCap);
            return delta < cap ? delta : cap;
        }
        return BackoffDelay(attempt);
    }

    private TimeSpan BackoffDelay(int attempt)
        => TimeSpan.FromSeconds(_retryBackoff * Math.Pow(2, attempt));

    /// <summary>Thread-safe rate limiter spacing outbound requests to at most the given rate. No-op when rate is null.</summary>
    private sealed class RateLimiter
    {
        private readonly double? _minIntervalSeconds;
        private long _nextTicks;
        private readonly object _lock = new();

        public RateLimiter(double? ratePerSecond)
        {
            _minIntervalSeconds = ratePerSecond.HasValue && ratePerSecond.Value > 0 ? 1.0 / ratePerSecond.Value : (double?)null;
            _nextTicks = Stopwatch.GetTimestamp();
        }

        public void Acquire()
        {
            if (_minIntervalSeconds is not { } interval) return;
            double waitSeconds;
            lock (_lock)
            {
                var now = Stopwatch.GetTimestamp();
                var next = Math.Max(now, _nextTicks);
                waitSeconds = (next - now) / (double)Stopwatch.Frequency;
                _nextTicks = next + (long)(interval * Stopwatch.Frequency);
            }
            if (waitSeconds > 0) Thread.Sleep(TimeSpan.FromSeconds(waitSeconds));
        }
    }

    public void Dispose() => _http.Dispose();
}
