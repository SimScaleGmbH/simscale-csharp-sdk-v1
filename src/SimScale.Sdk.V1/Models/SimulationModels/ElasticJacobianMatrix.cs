using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Select which stiffnes matrix should be used for computing the Jacobian of the Newton method. Choosing the tangent stiffnes matrix via tangent matrix allows a full Newton approach whereas the selection of the elastic matrix results in a quasi-Newton approach.</summary>
public class ElasticJacobianMatrix : OneOf_NewtonResolutionTypeJacobianMatrix, OneOf_NewtonKrylovResolutionTypeJacobianMatrix
{
    /// <summary>Select which stiffnes matrix should be used for computing the Jacobian of the Newton method. Choosing the tangent sti...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELASTIC";

    /// <summary>Maximum number of allowed Newton iterations per time increment. If this value is reached the simulation is considered...</summary>
    [JsonPropertyName("maxNewtonIteration")]
    public int? MaxNewtonIteration { get; set; }

}
