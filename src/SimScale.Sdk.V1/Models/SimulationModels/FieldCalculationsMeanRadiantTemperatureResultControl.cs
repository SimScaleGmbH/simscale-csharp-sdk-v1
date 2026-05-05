using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Computes the Mean Radiant Temperature (MRT). It is defined as the uniform surface temperature of an imaginary black enclosure in which an every point of the domain would exchange the same amount of radiative heat as in the actual nonuniform space</summary>
public class FieldCalculationsMeanRadiantTemperatureResultControl : OneOf_FluidResultControlsFieldCalculations
{
    /// <summary>Computes the Mean Radiant Temperature (MRT). It is defined as the uniform surface temperature of an imaginary black e...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MEAN_RADIANT_TEMPERATURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resultType")]
    public MeanRadiantTemperatureResultType? ResultType { get; set; }

    [JsonPropertyName("mrtSolarParameters")]
    public MrtSolarParameters? MrtSolarParameters { get; set; }

}
