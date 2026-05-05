using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolarCalculator
{
    [JsonPropertyName("sunDirection")]
    public OneOf_SolarCalculatorSunDirection? SunDirection { get; set; }

    [JsonPropertyName("solarLoad")]
    public OneOf_SolarCalculatorSolarLoad? SolarLoad { get; set; }

}
