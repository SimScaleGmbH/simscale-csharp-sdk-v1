using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Tolerance
{
    /// <summary>Absolute tolerance is the measure of residual in the solution after the current iteration is solved. The solution is...</summary>
    [JsonPropertyName("absoluteTolerance")]
    public double? AbsoluteTolerance { get; set; }

    /// <summary>Relative tolerance is the ratio of current residual to the initial residual. The solution is stopped when the relativ...</summary>
    [JsonPropertyName("relativeTolerance")]
    public double? RelativeTolerance { get; set; }

}
