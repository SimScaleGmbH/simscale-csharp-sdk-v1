using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalDisplacementType
{
    /// <summary>Schema name: GlobalDisplacementType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GLOBAL";

    [JsonPropertyName("complexNumber")]
    public string? ComplexNumber { get; set; }

}
