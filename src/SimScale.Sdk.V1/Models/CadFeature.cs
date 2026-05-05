using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CadFeature
{
    /// <summary>The ID of the CAD feature.</summary>
    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid Id { get; set; }

    /// <summary>The type of the CAD feature.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The parameters of the CAD feature.</summary>
    [JsonPropertyName("parameters")]
    public Dictionary<string, JsonElement>? Parameters { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The depth of the CAD feature in the feature list.</summary>
    [JsonPropertyName("depth")]
    public int? Depth { get; set; }

    [JsonPropertyName("failureReason")]
    public LogEntry? FailureReason { get; set; }

}
