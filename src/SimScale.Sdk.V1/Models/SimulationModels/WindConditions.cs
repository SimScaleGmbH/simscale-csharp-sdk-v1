using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WindConditions
{
    [JsonPropertyName("geographicalLocation")]
    public GeographicalLocation? GeographicalLocation { get; set; }

    [JsonPropertyName("windRose")]
    public WindRose? WindRose { get; set; }

}
