using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ReactionForceType : OneOf_ForceFieldSelectionForceType
{
    /// <summary>Schema name: ReactionForceType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REACTION";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
