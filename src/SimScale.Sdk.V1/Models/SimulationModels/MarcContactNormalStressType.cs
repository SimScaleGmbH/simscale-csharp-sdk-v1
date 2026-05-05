using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactNormalStressType : OneOf_MarcContactFieldSelectionContactType
{
    /// <summary>Schema name: MarcContactNormalStressType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NORMAL_STRESS";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
