using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcContactNormalForceType : OneOf_MarcContactForceFieldSelectionContactType
{
    /// <summary>Schema name: MarcContactNormalForceType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NORMAL_FORCE";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
