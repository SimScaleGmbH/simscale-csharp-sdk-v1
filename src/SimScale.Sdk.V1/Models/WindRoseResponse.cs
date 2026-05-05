using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.SimulationModels;

namespace SimScale.Sdk.V1.Models;

/// <summary>Wrapper containing WindRose schema</summary>
public class WindRoseResponse
{
    [JsonPropertyName("windRose")]
    [JsonRequired]
    public required WindRose WindRose { get; set; }

}
