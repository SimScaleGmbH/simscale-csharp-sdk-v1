using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueNBC : OneOf_CustomFluidBCNuTilda
{
    /// <summary>Schema name: FixedValueNBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public Dimensional_KinematicViscosity? Value { get; set; }

}
