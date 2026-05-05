using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ForcePreload
{
    /// <summary>Schema name: ForcePreload</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FORCE";

    [JsonPropertyName("force")]
    public Dimensional_Force? Force { get; set; }

}
