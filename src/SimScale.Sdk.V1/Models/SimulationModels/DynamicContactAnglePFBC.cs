using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DynamicContactAnglePFBC : OneOf_CustomFluidBCPhaseFraction, OneOf_WallBCPhaseFraction
{
    /// <summary>Schema name: DynamicContactAnglePFBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DYNAMIC_CONTACT_ANGLE";

    [JsonPropertyName("equilibriumContactAngle")]
    public Dimensional_Angle? EquilibriumContactAngle { get; set; }

    [JsonPropertyName("advancingContactAngle")]
    public Dimensional_Angle? AdvancingContactAngle { get; set; }

    [JsonPropertyName("recedingContactAngle")]
    public Dimensional_Angle? RecedingContactAngle { get; set; }

    [JsonPropertyName("velocityScaleOfContactAngle")]
    public double? VelocityScaleOfContactAngle { get; set; }

    [JsonPropertyName("limit")]
    public string? Limit { get; set; }

}
