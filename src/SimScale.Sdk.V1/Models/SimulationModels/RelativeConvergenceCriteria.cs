using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RelativeConvergenceCriteria : OneOf_NewtonKrylovResolutionTypeConvergenceCriteria, OneOf_NewtonResolutionTypeConvergenceCriteria
{
    /// <summary>Schema name: RelativeConvergenceCriteria</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE";

    /// <summary>Set the threshold value for the relative convergence criterion. With this criterion, the solver considers a time step...</summary>
    [JsonPropertyName("tolerance")]
    public double? Tolerance { get; set; }

}
