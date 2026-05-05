using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ReactionMomentType : OneOf_MomentFieldSelectionMomentType
{
    /// <summary>Schema name: ReactionMomentType</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REACTION";

    [JsonPropertyName("componentSelection")]
    public string? ComponentSelection { get; set; }

}
