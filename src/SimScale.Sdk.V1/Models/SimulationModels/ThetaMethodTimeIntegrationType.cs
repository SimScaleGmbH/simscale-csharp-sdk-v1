using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose the time integration scheme type</summary>
public class ThetaMethodTimeIntegrationType
{
    /// <summary>Choose the time integration scheme type Schema name: ThetaMethodTimeIntegrationType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "THETA_METHOD";

    /// <summary>The parameter &amp;theta; must be ranging between 0.0 (explicit method) and 1.0 (completely implicit method). The sta...</summary>
    [JsonPropertyName("theta")]
    public double? Theta { get; set; }

}
