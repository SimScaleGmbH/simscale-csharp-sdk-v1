using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose if the Jacobian matrix should automatically change from tangent stiffnes matrix to elastic matrix if the time increment is falling below a given threshold. On the assumption that below a given time increment value the nonlinearities are not evolving within the time step one can strongly save computation time by switching to the elastic matrix.</summary>
public class FalseChangeJacobianMatrix : OneOf_TangentJacobianMatrixChangeJacobianMatrix
{
    /// <summary>Choose if the Jacobian matrix should automatically change from tangent stiffnes matrix to elastic matrix if the time...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FALSE";

}
