namespace SimScale.Sdk.V1;

/// <summary>
/// Raised when an operation fails or a setup check has errors.
/// </summary>
public class SimScaleOperationError : Exception
{
    public object Result { get; }
    public string? Status { get; }

    public SimScaleOperationError(object result, string? status = null, string message = "Operation failed")
        : base(FormatMessage(result, status, message))
    {
        Result = result;
        Status = status;
    }

    private static string FormatMessage(object result, string? status, string message)
    {
        var lines = new List<string>();
        var header = status != null ? $"{message} (status: {status})" : message;
        lines.Add(header);

        // Try to read FailureReason property
        var failureReason = result.GetType().GetProperty("FailureReason")?.GetValue(result) as string;
        if (!string.IsNullOrEmpty(failureReason))
            lines.Add($"  {failureReason}");

        // Try to read Entries property (list of objects with Severity, Code, Message)
        if (result.GetType().GetProperty("Entries")?.GetValue(result) is System.Collections.IEnumerable entries)
        {
            foreach (var entry in entries)
            {
                var entryType = entry.GetType();
                var severity = entryType.GetProperty("Severity")?.GetValue(entry) as string;
                var code = entryType.GetProperty("Code")?.GetValue(entry) as string;
                var msg = entryType.GetProperty("Message")?.GetValue(entry) as string;

                var parts = new List<string>();
                if (!string.IsNullOrEmpty(severity))
                    parts.Add(severity);
                if (!string.IsNullOrEmpty(code) && !string.IsNullOrEmpty(msg))
                    parts.Add($"{code}:");
                else if (!string.IsNullOrEmpty(code))
                    parts.Add(code);
                if (!string.IsNullOrEmpty(msg))
                    parts.Add(msg);

                var entryLine = string.Join(" ", parts);
                if (!string.IsNullOrEmpty(entryLine))
                    lines.Add($"  {entryLine}");
            }
        }

        return string.Join("\n", lines);
    }
}
