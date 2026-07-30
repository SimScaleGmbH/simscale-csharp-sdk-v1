using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MeanValuePBC : OneOf_CustomFluidBCPressure, OneOf_CustomFluidBCPressureRgh, OneOf_CustomFluidBCGaugePressure, OneOf_CustomFluidBCGaugePressureRgh, OneOf_PressureOutletBCPressure, OneOf_PressureOutletBCPressureRgh, OneOf_PressureOutletBCGaugePressure, OneOf_PressureOutletBCGaugePressureRgh
{
    /// <summary>Schema name: MeanValuePBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_MEAN";

    [JsonPropertyName("value")]
    public Dimensional_Pressure? Value { get; set; }

}
