using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AbsoluteConvergenceCriteria : OneOf_NewtonResolutionTypeConvergenceCriteria, OneOf_NewtonKrylovResolutionTypeConvergenceCriteria
{
    /// <summary>Schema name: AbsoluteConvergenceCriteria</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE";

    /// <summary>Set the threshold value for the absolute convergence criterion (measured in Newtons). With this criterion, the solver...</summary>
    [JsonPropertyName("tolerance")]
    public double? Tolerance { get; set; }

}
