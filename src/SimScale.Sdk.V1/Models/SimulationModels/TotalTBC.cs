using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TotalTBC : OneOf_CustomFluidBCTemperature, OneOf_WallBCTemperature, OneOf_PressureInletBCTemperature, OneOf_VelocityInletBCTemperature
{
    /// <summary>Schema name: TotalTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TOTAL_TEMPERATURE";

    [JsonPropertyName("totalTemperature")]
    public Dimensional_Temperature? TotalTemperature { get; set; }

    [JsonPropertyName("totalTemperatureFunction")]
    public DimensionalFunction_Temperature? TotalTemperatureFunction { get; set; }

    [JsonPropertyName("specificHeatRatio")]
    public double? SpecificHeatRatio { get; set; }

}
