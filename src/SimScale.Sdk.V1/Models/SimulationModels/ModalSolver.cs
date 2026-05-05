using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ModalSolver
{
    [JsonPropertyName("solver")]
    public OneOf_ModalSolverSolver? Solver { get; set; }

    [JsonPropertyName("solverModel")]
    public SolverModel? SolverModel { get; set; }

    [JsonPropertyName("eigenSolver")]
    public OneOf_ModalSolverEigenSolver? EigenSolver { get; set; }

    [JsonPropertyName("calculateFrequency")]
    public CalculateFrequency? CalculateFrequency { get; set; }

    [JsonPropertyName("eigenMode")]
    public EigenModeVerification? EigenMode { get; set; }

    /// <summary>Further increase the accuracy of the results by running two simulations. The results of the first one will be used as...</summary>
    [JsonPropertyName("enhancedAccuracy")]
    public bool? EnhancedAccuracy { get; set; }

}
