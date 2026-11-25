using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdaptiveConvergenceCriteria : OneOf_NewtonKrylovResolutionTypeConvergenceCriteria, OneOf_NewtonResolutionTypeConvergenceCriteria
{
    /// <summary>Schema name: AdaptiveConvergenceCriteria</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ADAPTIVE";

    /// <summary>Set the threshold value for the relative convergence criterion. With this criterion, the solver considers a time step...</summary>
    [JsonPropertyName("relativeTolerance")]
    public double? RelativeTolerance { get; set; }

    /// <summary>Set the threshold value for the absolute convergence criterion (measured in Newtons). With this criterion, the solver...</summary>
    [JsonPropertyName("absoluteTolerance")]
    public double? AbsoluteTolerance { get; set; }

}
