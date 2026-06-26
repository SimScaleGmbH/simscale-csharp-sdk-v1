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

    public SimScaleClient(string apiKey, string serverUrl, int maxRetries = 5, double retryBackoff = 0.2)
    {
        _http = new HttpClient
        {
            BaseAddress = new Uri(serverUrl.TrimEnd('/') + "/"),
            Timeout = TimeSpan.FromSeconds(30),
        };
        _http.DefaultRequestHeaders.Add("X-API-KEY", apiKey);
        _http.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgent);
        _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _maxRetries = maxRetries;
        _retryBackoff = retryBackoff;
    }

    public T Request<T>(HttpMethod method, string path, object? body = null,
        Stream? binaryBody = null,
        string? contentType = null,
        Dictionary<string, object?>? queryParams = null)
    {
        using var response = SendRequest(method, path, body, binaryBody, contentType, queryParams);
        var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
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

        var response = SendWithRetry(method, () =>
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
    /// regardless of method. Honors Retry-After on 429 when present.
    /// </summary>
    private HttpResponseMessage SendWithRetry(HttpMethod method, Func<HttpResponseMessage> send)
    {
        Exception? lastExc = null;
        for (var attempt = 0; attempt <= _maxRetries; attempt++)
        {
            HttpResponseMessage resp;
            try
            {
                resp = send();
            }
            catch (Exception e) when (e is HttpRequestException or TaskCanceledException)
            {
                lastExc = e;
                if (attempt >= _maxRetries || !IdempotentMethods.Contains(method))
                    throw;
                Thread.Sleep(BackoffDelay(attempt));
                continue;
            }

            var status = (int)resp.StatusCode;
            var retryStatus = status == 429
                || (RetriableStatuses.Contains(status) && IdempotentMethods.Contains(method));
            if (retryStatus && attempt < _maxRetries)
            {
                var delay = RetryDelay(attempt, resp);
                resp.Dispose();
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
            return delta;
        return BackoffDelay(attempt);
    }

    private TimeSpan BackoffDelay(int attempt)
        => TimeSpan.FromSeconds(_retryBackoff * Math.Pow(2, attempt));

    public void Dispose() => _http.Dispose();
}
