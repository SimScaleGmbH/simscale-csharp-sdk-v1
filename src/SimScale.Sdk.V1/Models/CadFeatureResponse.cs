using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CadFeatureResponse
{
    /// <summary>The ID of the CAD state once completed.</summary>
    [JsonPropertyName("cadStateId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CadStateId { get; set; }

    /// <summary>The ID of the CAD feature once completed.</summary>
    [JsonPropertyName("cadFeatureId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CadFeatureId { get; set; }

    [JsonPropertyName("status")]
    [JsonRequired]
    public required string Status { get; set; }

    [JsonPropertyName("failureReason")]
    public LogEntry? FailureReason { get; set; }

}
