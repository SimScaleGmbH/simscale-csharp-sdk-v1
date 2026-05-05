using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticNumerics
{
    /// <summary>The nonlinear residual error is computed as the difference between the calculated and expected flux density value whe...</summary>
    [JsonPropertyName("nonlinearResidual")]
    public double? NonlinearResidual { get; set; }

    /// <summary>Uses second order element shape functions for a higher accuracy. Especially recommended when calculating torques or f...</summary>
    [JsonPropertyName("elementAccuracy")]
    public string? ElementAccuracy { get; set; }

}
