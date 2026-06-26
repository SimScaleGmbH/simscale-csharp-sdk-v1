using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeConvergenceResiduals : OneOf_ResidualsConvergenceMethodConvergenceCriteria
{
    /// <summary>Schema name: RelativeConvergenceResiduals</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE";

    /// <summary>The ratio of the maximum residual force to the maximum reaction force (or applied load). A typical value is 5 &amp;ti...</summary>
    [JsonPropertyName("relativeForceTolerance")]
    public double? RelativeForceTolerance { get; set; }

    [JsonPropertyName("relativeMomentTolerance")]
    public double? RelativeMomentTolerance { get; set; }

    /// <summary>Auto switch method: Automatically toggles the convergence criteria between residual, displacement, or energy methods...</summary>
    [JsonPropertyName("relativeResidualAutoSwitch")]
    public bool? RelativeResidualAutoSwitch { get; set; }

}
