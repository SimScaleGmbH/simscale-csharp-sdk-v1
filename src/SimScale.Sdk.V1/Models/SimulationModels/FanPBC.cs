using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FanPBC : OneOf_CustomFluidBCPressure, OneOf_CustomFluidBCPressureRgh, OneOf_CustomFluidBCGaugePressure, OneOf_CustomFluidBCGaugePressureRgh, OneOf_FanBCPressureRgh
{
    /// <summary>Schema name: FanPBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FAN_PRESSURE";

    [JsonPropertyName("fanPressure")]
    public DimensionalFunction_Pressure? FanPressure { get; set; }

    [JsonPropertyName("environmentalTotalPressure")]
    public Dimensional_Pressure? EnvironmentalTotalPressure { get; set; }

}
