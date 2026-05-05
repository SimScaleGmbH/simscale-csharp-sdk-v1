using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CadImportResponse
{
    /// <summary>The ID of the CAD.</summary>
    [JsonPropertyName("cadId")]
    [JsonRequired]
    public required Guid CadId { get; set; }

    [JsonPropertyName("status")]
    [JsonRequired]
    public required string Status { get; set; }

    /// <summary>The ID of the current CAD state. It can point to an empty CAD state in case the import is running or failed.</summary>
    [JsonPropertyName("cadStateId")]
    [JsonRequired]
    public required Guid CadStateId { get; set; }

    [JsonPropertyName("failureReason")]
    public LogEntry? FailureReason { get; set; }

}
