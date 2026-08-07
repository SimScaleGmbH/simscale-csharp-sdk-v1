using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueTBC : OneOf_WallBCTemperature, OneOf_CustomFluidBCTemperature, OneOf_FanBCTemperature, OneOf_VelocityInletBCTemperature, OneOf_PressureInletBCTemperature
{
    /// <summary>Schema name: FixedValueTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public DimensionalFunction_Temperature? Value { get; set; }

}
