using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FieldCalculationsThermalComfortResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Schema name: FieldCalculationsThermalComfortResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "THERMAL_COMFORT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("clothingCoefficientFactor")]
    public double? ClothingCoefficientFactor { get; set; }

    [JsonPropertyName("metabolicRateFactor")]
    public double? MetabolicRateFactor { get; set; }

    [JsonPropertyName("relativeHumidityFactor")]
    public double? RelativeHumidityFactor { get; set; }

    [JsonPropertyName("mrtSolarParameters")]
    public MrtSolarParameters? MrtSolarParameters { get; set; }

}
