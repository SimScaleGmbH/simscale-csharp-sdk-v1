using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class DeleteFaceV2Parameters
{
    /// <summary>List of faces.</summary>
    [JsonPropertyName("faces")]
    public List<string>? Faces { get; set; }

    /// <summary>The available healing actions are: - `cap`: replaces deleted faces with a new face, - `shrink`: closes the hole left...</summary>
    [JsonPropertyName("heal_action")]
    [JsonRequired]
    public required string HealAction { get; set; }

}
