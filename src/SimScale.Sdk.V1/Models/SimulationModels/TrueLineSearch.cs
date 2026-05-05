using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Line search can be used to improve convergence for nonlinear calculations with the Newton method.</summary>
public class TrueLineSearch : OneOf_SolidNumericsMechanicalLineSearch, OneOf_SolidNumericsThermalLineSearch
{
    /// <summary>Line search can be used to improve convergence for nonlinear calculations with the Newton method. Schema name: TrueLi...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRUE";

    /// <summary>Choose the method of the line search algorithm. The Secant method is a simple one dimensional search algorithm. The m...</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Set the residual for the line search convergence</summary>
    [JsonPropertyName("residual")]
    public double? Residual { get; set; }

    /// <summary>Set the maximum number for line search iterations. Typically a sinlge-digit number should be sufficient.</summary>
    [JsonPropertyName("maxIterations")]
    public int? MaxIterations { get; set; }

}
