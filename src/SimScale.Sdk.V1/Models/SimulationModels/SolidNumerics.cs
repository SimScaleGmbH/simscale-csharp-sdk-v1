using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolidNumerics
{
    /// <summary>Select the basis for the computation of the harmonic analysis.</summary>
    [JsonPropertyName("harmonicSolutionMethod")]
    public string? HarmonicSolutionMethod { get; set; }

    [JsonPropertyName("solver")]
    public OneOf_SolidNumericsSolver? Solver { get; set; }

    [JsonPropertyName("solveModel")]
    public SolverModel? SolveModel { get; set; }

    [JsonPropertyName("eigenSolver")]
    public OneOf_SolidNumericsEigenSolver? EigenSolver { get; set; }

    [JsonPropertyName("calculateFrequency")]
    public CalculateFrequency? CalculateFrequency { get; set; }

    [JsonPropertyName("eigenMode")]
    public EigenModeVerification? EigenMode { get; set; }

    /// <summary>Further increase the accuracy of the results by running two simulations. The results of the first one will be used as...</summary>
    [JsonPropertyName("enhancedAccuracy")]
    public bool? EnhancedAccuracy { get; set; }

    [JsonPropertyName("modalBase")]
    public ModalSolver? ModalBase { get; set; }

    [JsonPropertyName("harmonicResponse")]
    public HarmonicResponse? HarmonicResponse { get; set; }

    [JsonPropertyName("mechanicalTimeIntegrationType")]
    public OneOf_SolidNumericsMechanicalTimeIntegrationType? MechanicalTimeIntegrationType { get; set; }

    [JsonPropertyName("mechanicalResolutionType")]
    public OneOf_SolidNumericsMechanicalResolutionType? MechanicalResolutionType { get; set; }

    [JsonPropertyName("mechanicalLineSearch")]
    public OneOf_SolidNumericsMechanicalLineSearch? MechanicalLineSearch { get; set; }

    [JsonPropertyName("thermalTimeIntegrationType")]
    public ThetaMethodTimeIntegrationType? ThermalTimeIntegrationType { get; set; }

    [JsonPropertyName("thermalResolutionType")]
    public OneOf_SolidNumericsThermalResolutionType? ThermalResolutionType { get; set; }

    [JsonPropertyName("thermalLineSearch")]
    public OneOf_SolidNumericsThermalLineSearch? ThermalLineSearch { get; set; }

    [JsonPropertyName("remotePointStiffnessMultiplier")]
    public double? RemotePointStiffnessMultiplier { get; set; }

}
