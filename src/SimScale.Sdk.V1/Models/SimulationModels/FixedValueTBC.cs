using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueTBC : OneOf_CustomFluidBCTemperature, OneOf_WallBCTemperature, OneOf_FanBCTemperature, OneOf_PressureInletBCTemperature, OneOf_VelocityInletBCTemperature
{
    /// <summary>Schema name: FixedValueTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public DimensionalFunction_Temperature? Value { get; set; }

}
