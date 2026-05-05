using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdaptiveConvergenceResidualsOrDisplacements : OneOf_ResidualsOrDisplacementsConvergenceMethodConvergenceCriteria
{
    /// <summary>Schema name: AdaptiveConvergenceResidualsOrDisplacements</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ADAPTIVE";

    [JsonPropertyName("relativeForceTolerance")]
    public double? RelativeForceTolerance { get; set; }

    [JsonPropertyName("maxResidualForce")]
    public Dimensional_Force? MaxResidualForce { get; set; }

    [JsonPropertyName("relativeMomentTolerance")]
    public double? RelativeMomentTolerance { get; set; }

    [JsonPropertyName("maxResidualMoment")]
    public Dimensional_Torque? MaxResidualMoment { get; set; }

    [JsonPropertyName("relativeDisplacementTolerance")]
    public double? RelativeDisplacementTolerance { get; set; }

    [JsonPropertyName("maxDisplacementIncrement")]
    public Dimensional_Length? MaxDisplacementIncrement { get; set; }

    [JsonPropertyName("relativeRotationTolerance")]
    public double? RelativeRotationTolerance { get; set; }

    [JsonPropertyName("maxRotationIncrement")]
    public Dimensional_Angle? MaxRotationIncrement { get; set; }

}
