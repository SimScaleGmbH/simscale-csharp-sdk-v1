using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FrictionPenaltyCoef : OneOf_FrictionContactFrictionCoefficient
{
    /// <summary>Schema name: FrictionPenaltyCoef</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FRICTION_PENALTY_COEF";

    [JsonPropertyName("frictionPenaltyCoefficient")]
    public double? FrictionPenaltyCoefficient { get; set; }

    [JsonPropertyName("coulombCoefficient")]
    public double? CoulombCoefficient { get; set; }

}
