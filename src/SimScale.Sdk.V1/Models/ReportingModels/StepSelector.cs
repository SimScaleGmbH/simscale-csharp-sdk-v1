using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Selects which solution steps to scan. A step is one entry in the result sequence: a time-step for a transient analysis, or a frequency for a harmonic analysis. Set selection to FIRST or LAST for a single boundary step, ALL for every step, or INDICES for a specific set given in indices (0-based). indices applies only when selection is INDICES.</summary>
public class StepSelector
{
    [JsonPropertyName("selection")]
    [JsonRequired]
    public required string Selection { get; set; }

    /// <summary>The 0-based step indices to scan; used only when selection is INDICES.</summary>
    [JsonPropertyName("indices")]
    public List<int>? Indices { get; set; }

}
