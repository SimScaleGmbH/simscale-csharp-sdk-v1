using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcTemperatureResultControlItem : OneOf_MarcResultControlSolutionFields
{
    /// <summary>Schema name: MarcTemperatureResultControlItem</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TEMPERATURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

}
