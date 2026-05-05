using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class LogEntry
{
    [JsonPropertyName("severity")]
    [JsonRequired]
    public required string Severity { get; set; }

    /// <summary>Code for e.g. programmatic handling of error conditions.</summary>
    [JsonPropertyName("code")]
    [JsonRequired]
    public required string Code { get; set; }

    /// <summary>Human-readable description of the entry.</summary>
    [JsonPropertyName("message")]
    [JsonRequired]
    public required string Message { get; set; }

    /// <summary>Additional data to interpret and handle the entry.</summary>
    [JsonPropertyName("details")]
    public Dictionary<string, JsonElement>? Details { get; set; }

}
