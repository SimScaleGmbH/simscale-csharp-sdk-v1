using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TemperatureResultControlItem : OneOf_SolidResultControlSolutionFields
{
    /// <summary>Schema name: TemperatureResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TEMPERATURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("temperatureType")]
    public string? TemperatureType { get; set; }

}
