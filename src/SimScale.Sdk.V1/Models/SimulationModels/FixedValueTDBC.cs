using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueTDBC : OneOf_CustomFluidBCTurbulentThermalDiffusivity
{
    /// <summary>Schema name: FixedValueTDBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public Dimensional_DynamicViscosity? Value { get; set; }

}
