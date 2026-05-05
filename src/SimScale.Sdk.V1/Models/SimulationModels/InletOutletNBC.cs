using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InletOutletNBC : OneOf_CustomFluidBCNuTilda
{
    /// <summary>Schema name: InletOutletNBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INLET_OUTLET";

    [JsonPropertyName("value")]
    public Dimensional_KinematicViscosity? Value { get; set; }

}
