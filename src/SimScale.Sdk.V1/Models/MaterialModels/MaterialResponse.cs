using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MaterialModels;

public class MaterialResponse
{
    /// <summary>The material unique identifier.</summary>
    [JsonPropertyName("id")]
    [JsonRequired]
    public required string Id { get; set; }

    /// <summary>The material group unique identifier.</summary>
    [JsonPropertyName("materialGroupId")]
    [JsonRequired]
    public required string MaterialGroupId { get; set; }

    /// <summary>The material name.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    /// <summary>The time the material was created.</summary>
    [JsonPropertyName("createdAt")]
    [JsonRequired]
    public required DateTimeOffset CreatedAt { get; set; }

    /// <summary>The time the material was modified.</summary>
    [JsonPropertyName("modifiedAt")]
    [JsonRequired]
    public required DateTimeOffset ModifiedAt { get; set; }

    [JsonPropertyName("properties")]
    public MaterialProperties? Properties { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, JsonElement>? Metadata { get; set; }

}
