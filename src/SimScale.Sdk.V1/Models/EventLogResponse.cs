using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class EventLogResponse
{
    [JsonPropertyName("entries")]
    [JsonRequired]
    public required List<LogEntry> Entries { get; set; }

}
