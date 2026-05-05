using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CheckResponse
{
    [JsonPropertyName("severity")]
    [JsonRequired]
    public required string Severity { get; set; }

    [JsonPropertyName("entries")]
    [JsonRequired]
    public required List<LogEntry> Entries { get; set; }

}
