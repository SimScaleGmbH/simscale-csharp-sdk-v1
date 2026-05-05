using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class SwapCadRequest
{
    /// <summary>The ID of the assigned CAD.</summary>
    [JsonPropertyName("sourceCadId")]
    [JsonRequired]
    public required Guid SourceCadId { get; set; }

    /// <summary>The ID of the assigned CAD state.</summary>
    [JsonPropertyName("sourceCadStateId")]
    [JsonRequired]
    public required Guid SourceCadStateId { get; set; }

    /// <summary>The ID of the CAD to assign.</summary>
    [JsonPropertyName("targetCadId")]
    [JsonRequired]
    public required Guid TargetCadId { get; set; }

    /// <summary>The ID of the CAD state to assign.</summary>
    [JsonPropertyName("targetCadStateId")]
    [JsonRequired]
    public required Guid TargetCadStateId { get; set; }

}
