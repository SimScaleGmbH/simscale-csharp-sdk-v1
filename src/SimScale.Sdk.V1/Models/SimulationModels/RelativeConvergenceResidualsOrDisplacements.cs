using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeConvergenceResidualsOrDisplacements : OneOf_ResidualsOrDisplacementsConvergenceMethodConvergenceCriteria
{
    /// <summary>Schema name: RelativeConvergenceResidualsOrDisplacements</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE";

    [JsonPropertyName("relativeForceTolerance")]
    public double? RelativeForceTolerance { get; set; }

    [JsonPropertyName("relativeMomentTolerance")]
    public double? RelativeMomentTolerance { get; set; }

    [JsonPropertyName("relativeDisplacementTolerance")]
    public double? RelativeDisplacementTolerance { get; set; }

    [JsonPropertyName("relativeRotationTolerance")]
    public double? RelativeRotationTolerance { get; set; }

}
