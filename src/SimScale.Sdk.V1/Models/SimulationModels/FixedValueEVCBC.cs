using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueEVCBC : OneOf_CustomFluidBCEddyViscosityCompressible
{
    /// <summary>Schema name: FixedValueEVCBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public Dimensional_DynamicViscosity? Value { get; set; }

}
