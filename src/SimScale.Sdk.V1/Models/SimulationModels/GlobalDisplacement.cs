using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalDisplacement
{
    /// <summary>Schema name: GlobalDisplacement</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GLOBAL";

}
