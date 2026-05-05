using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomSolarLoad : OneOf_SolarCalculatorSolarLoad
{
    /// <summary>Schema name: CustomSolarLoad</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_SOLAR_LOAD";

    [JsonPropertyName("directSolarLoad")]
    public Dimensional_HeatFlux? DirectSolarLoad { get; set; }

    [JsonPropertyName("diffuseSolarLoad")]
    public Dimensional_HeatFlux? DiffuseSolarLoad { get; set; }

}
