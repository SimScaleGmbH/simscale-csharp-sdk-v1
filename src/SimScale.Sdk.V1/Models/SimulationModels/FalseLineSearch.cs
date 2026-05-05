using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Line search can be used to improve convergence for nonlinear calculations with the Newton method.</summary>
public class FalseLineSearch : OneOf_SolidNumericsMechanicalLineSearch, OneOf_SolidNumericsThermalLineSearch
{
    /// <summary>Line search can be used to improve convergence for nonlinear calculations with the Newton method. Schema name: FalseL...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FALSE";

}
