using System.Net;
using System.Text.Json;

namespace SimScale.Sdk.V1;

public class SimScaleAPIError : Exception
{
    public int StatusCode { get; }
    public string ResponseBody { get; }
    public string? Url { get; }

    public SimScaleAPIError(int statusCode, string responseBody, string? url = null)
        : base(FormatMessage(statusCode, responseBody, url))
    {
        StatusCode = statusCode;
        ResponseBody = responseBody;
        Url = url;
    }

    private static string FormatMessage(int statusCode, string responseBody, string? url)
    {
        var reason = ((HttpStatusCode)statusCode).ToString();
        var statusLine = url != null ? $"{statusCode} {reason}: {url}" : $"{statusCode} {reason}";

        try
        {
            using var doc = JsonDocument.Parse(responseBody);
            var root = doc.RootElement;

            var lines = new List<string>
            {
                responseBody,
                "",
                statusLine,
            };

            var severity = root.TryGetProperty("severity", out var sevEl) ? sevEl.GetString() : null;
            var code = root.TryGetProperty("code", out var codeEl) ? codeEl.GetString() : null;
            var message = root.TryGetProperty("message", out var msgEl) ? msgEl.GetString() : null;

            var mainParts = new List<string>();
            if (!string.IsNullOrEmpty(severity))
                mainParts.Add(severity);
            if (!string.IsNullOrEmpty(code) && !string.IsNullOrEmpty(message))
                mainParts.Add($"{code}:");
            else if (!string.IsNullOrEmpty(code))
                mainParts.Add(code);
            if (!string.IsNullOrEmpty(message))
                mainParts.Add(message);

            var main = string.Join(" ", mainParts);
            if (!string.IsNullOrEmpty(main))
                lines.Add($"  {main}");

            if (root.TryGetProperty("entries", out var entriesEl) && entriesEl.ValueKind == JsonValueKind.Array)
            {
                foreach (var entry in entriesEl.EnumerateArray())
                {
                    var eSev = entry.TryGetProperty("severity", out var esEl) ? esEl.GetString() : null;
                    var eCode = entry.TryGetProperty("code", out var ecEl) ? ecEl.GetString() : null;
                    var eMsg = entry.TryGetProperty("message", out var emEl) ? emEl.GetString() : null;

                    var entryParts = new List<string>();
                    if (!string.IsNullOrEmpty(eSev))
                        entryParts.Add(eSev);
                    if (!string.IsNullOrEmpty(eCode) && !string.IsNullOrEmpty(eMsg))
                        entryParts.Add($"{eCode}:");
                    else if (!string.IsNullOrEmpty(eCode))
                        entryParts.Add(eCode);
                    if (!string.IsNullOrEmpty(eMsg))
                        entryParts.Add(eMsg);

                    var entryLine = string.Join(" ", entryParts);
                    if (!string.IsNullOrEmpty(entryLine) && entryLine != main)
                        lines.Add($"  {entryLine}");
                }
            }

            if (root.TryGetProperty("trace", out var traceEl))
            {
                var trace = traceEl.GetString();
                if (!string.IsNullOrEmpty(trace))
                    lines.Add($"  (trace: {trace})");
            }

            return string.Join("\n", lines);
        }
        catch
        {
            return url != null
                ? $"{statusCode} {reason}: {url}\n{responseBody}"
                : $"{statusCode} {reason}: {responseBody}";
        }
    }
}
