using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MaterialModels;

public class CreateMaterialRequest
{
    /// <summary>The material name.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, JsonElement>? Metadata { get; set; }

    [JsonPropertyName("properties")]
    [JsonRequired]
    public required MaterialProperties Properties { get; set; }

}
