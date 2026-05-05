using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdaptiveConvergenceResiduals : OneOf_ResidualsConvergenceMethodConvergenceCriteria
{
    /// <summary>Schema name: AdaptiveConvergenceResiduals</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ADAPTIVE";

    /// <summary>The ratio of the maximum residual force to the maximum reaction force (or applied load). A typical value is 5 &amp;ti...</summary>
    [JsonPropertyName("relativeForceTolerance")]
    public double? RelativeForceTolerance { get; set; }

    [JsonPropertyName("maxResidualForce")]
    public Dimensional_Force? MaxResidualForce { get; set; }

    [JsonPropertyName("relativeMomentTolerance")]
    public double? RelativeMomentTolerance { get; set; }

    [JsonPropertyName("maxResidualMoment")]
    public Dimensional_Torque? MaxResidualMoment { get; set; }

}
