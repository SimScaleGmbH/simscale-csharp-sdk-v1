using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MaterialModels;

public class MaterialGroupResponse
{
    /// <summary>The ID of the material group.</summary>
    [JsonPropertyName("materialGroupId")]
    [JsonRequired]
    public required string MaterialGroupId { get; set; }

    /// <summary>The ID of parent of the material group.</summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>The name of the material group.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    [JsonPropertyName("groupType")]
    public string? GroupType { get; set; }

    /// <summary>The time the material group was created.</summary>
    [JsonPropertyName("createdAt")]
    [JsonRequired]
    public required DateTimeOffset CreatedAt { get; set; }

    /// <summary>The time the material group was modified.</summary>
    [JsonPropertyName("modifiedAt")]
    [JsonRequired]
    public required DateTimeOffset ModifiedAt { get; set; }

    /// <summary>Material group metadata.</summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, JsonElement>? Metadata { get; set; }

}
