using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ConstantContactAnglePFBC : OneOf_CustomFluidBCPhaseFraction, OneOf_WallBCPhaseFraction
{
    /// <summary>Schema name: ConstantContactAnglePFBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONSTANT_CONTACT_ANGLE";

    [JsonPropertyName("equilibriumContactAngle")]
    public Dimensional_Angle? EquilibriumContactAngle { get; set; }

    [JsonPropertyName("limit")]
    public string? Limit { get; set; }

}
