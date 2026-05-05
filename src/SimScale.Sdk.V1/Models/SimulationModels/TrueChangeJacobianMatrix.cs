using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose if the Jacobian matrix should automatically change from tangent stiffnes matrix to elastic matrix if the time increment is falling below a given threshold. On the assumption that below a given time increment value the nonlinearities are not evolving within the time step one can strongly save computation time by switching to the elastic matrix.</summary>
public class TrueChangeJacobianMatrix : OneOf_TangentJacobianMatrixChangeJacobianMatrix
{
    /// <summary>Choose if the Jacobian matrix should automatically change from tangent stiffnes matrix to elastic matrix if the time...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRUE";

    /// <summary>Set the threshold value of the Jacobian matrix changing. If the time increment is lower than this value the elastic m...</summary>
    [JsonPropertyName("thresholdTimeStepValue")]
    public double? ThresholdTimeStepValue { get; set; }

    /// <summary>Set how often the elastic stiffness matrix should be recomputed. If this parameter is set to 10, the elastic matrix i...</summary>
    [JsonPropertyName("matrixReactualizationIteration")]
    public int? MatrixReactualizationIteration { get; set; }

    /// <summary>Maximum number of allowed Newton iterations per time increment. If this value is reached the simulation is considered...</summary>
    [JsonPropertyName("maxNewtonIterations")]
    public int? MaxNewtonIterations { get; set; }

}
