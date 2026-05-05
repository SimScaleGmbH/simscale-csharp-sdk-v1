using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class InletOutletEVBC : OneOf_CustomFluidBCEddyViscosity
{
    /// <summary>Schema name: InletOutletEVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INLET_OUTLET";

    [JsonPropertyName("value")]
    public Dimensional_DynamicViscosity? Value { get; set; }

}
