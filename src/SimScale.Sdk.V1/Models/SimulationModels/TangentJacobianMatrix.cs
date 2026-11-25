using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Select which stiffnes matrix should be used for computing the Jacobian of the Newton method. Choosing the tangent stiffnes matrix via tangent matrix allows a full Newton approach whereas the selection of the elastic matrix results in a quasi-Newton approach.</summary>
public class TangentJacobianMatrix : OneOf_NewtonKrylovResolutionTypeJacobianMatrix, OneOf_NewtonResolutionTypeJacobianMatrix
{
    /// <summary>Select which stiffnes matrix should be used for computing the Jacobian of the Newton method. Choosing the tangent sti...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TANGENT";

    /// <summary>Maximum number of allowed Newton iterations per time increment. If this value is reached the simulation is considered...</summary>
    [JsonPropertyName("maxNewtonIteration")]
    public int? MaxNewtonIteration { get; set; }

    /// <summary>Select how often the Jacobian matrix should be recomputed. If this parameter is set to 10, the Jacobian matrix is rec...</summary>
    [JsonPropertyName("reactualizationIteration")]
    public int? ReactualizationIteration { get; set; }

    /// <summary>Select how often the Jacobian matrix should be recomputed. If this parameter is set to 10, the Jacobian matrix is rec...</summary>
    [JsonPropertyName("reactualizationIncrement")]
    public int? ReactualizationIncrement { get; set; }

    [JsonPropertyName("changeJacobianMatrix")]
    public OneOf_TangentJacobianMatrixChangeJacobianMatrix? ChangeJacobianMatrix { get; set; }

}
