using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcGlobalDisplacementFieldType
{
    /// <summary>Schema name: MarcGlobalDisplacementFieldType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GLOBAL";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
