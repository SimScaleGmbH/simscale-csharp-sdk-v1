namespace SimScale.Sdk.V1;

/// <summary>
/// Thrown when a request exhausts its retries on client-side timeouts. Fails
/// loud instead of hanging: carries the request context (method, url, elapsed,
/// attempts) so a stuck call surfaces as a clear, actionable error. The
/// underlying timeout is preserved as InnerException.
/// </summary>
public class SimScaleTimeoutException : Exception
{
    public string Method { get; }
    public string Url { get; }
    public double ElapsedSeconds { get; }
    public int Attempts { get; }

    public SimScaleTimeoutException(string method, string url, double elapsedSeconds, int attempts, Exception cause)
        : base($"{method} {url} timed out after {attempts} attempt(s), {elapsedSeconds:0.0}s total: {cause.Message}", cause)
    {
        Method = method;
        Url = url;
        ElapsedSeconds = elapsedSeconds;
        Attempts = attempts;
    }
}
