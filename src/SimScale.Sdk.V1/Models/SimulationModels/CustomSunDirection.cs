using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomSunDirection : OneOf_SolarCalculatorSunDirection
{
    /// <summary>Schema name: CustomSunDirection</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_SOLAR_DIRECTION";

    [JsonPropertyName("sunDirectionVector")]
    public DimensionalVector_Length? SunDirectionVector { get; set; }

}
