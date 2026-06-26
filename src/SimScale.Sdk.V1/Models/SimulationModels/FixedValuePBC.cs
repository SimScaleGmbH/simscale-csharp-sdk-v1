using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValuePBC : OneOf_PressureOutletBCPressure, OneOf_PressureOutletBCPressureRgh, OneOf_PressureOutletBCGaugePressure, OneOf_PressureOutletBCGaugePressureRgh, OneOf_CustomFluidBCPressure, OneOf_CustomFluidBCPressureRgh, OneOf_CustomFluidBCGaugePressure, OneOf_CustomFluidBCGaugePressureRgh, OneOf_FreestreamVBCAmbientPressure, OneOf_PressureInletBCPressure, OneOf_PressureInletBCGaugePressure
{
    /// <summary>Schema name: FixedValuePBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_VALUE";

    [JsonPropertyName("value")]
    public DimensionalFunction_Pressure? Value { get; set; }

}
