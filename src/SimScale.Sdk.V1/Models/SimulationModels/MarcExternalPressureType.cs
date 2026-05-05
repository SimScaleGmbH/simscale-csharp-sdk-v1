using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcExternalPressureType
{
    /// <summary>Schema name: MarcExternalPressureType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "EXTERNAL";

}
