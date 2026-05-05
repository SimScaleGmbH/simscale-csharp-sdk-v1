using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose how the nonlinearities are solved. Currently for direct solvers only the Newton-Raphson method is available via the selection Newton. For iterative solvers also an inexact version of the Newton-Raphson method is available via the selection Newton-Krylov.</summary>
public class NewtonResolutionType : OneOf_SolidNumericsMechanicalResolutionType, OneOf_SolidNumericsThermalResolutionType
{
    /// <summary>Choose how the nonlinearities are solved. Currently for direct solvers only the Newton-Raphson method is available vi...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NEWTON";

    [JsonPropertyName("convergenceCriteria")]
    public OneOf_NewtonResolutionTypeConvergenceCriteria? ConvergenceCriteria { get; set; }

    /// <summary>Select which stiffnes matrix should be used in the prediction phase of the Newton method. A good choice leads to a go...</summary>
    [JsonPropertyName("predictionMatrix")]
    public string? PredictionMatrix { get; set; }

    [JsonPropertyName("jacobianMatrix")]
    public OneOf_NewtonResolutionTypeJacobianMatrix? JacobianMatrix { get; set; }

}
