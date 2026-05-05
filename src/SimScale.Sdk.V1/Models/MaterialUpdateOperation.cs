using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.MaterialModels;

namespace SimScale.Sdk.V1.Models;

/// <summary>Material update operation, which can be either updating an existing material in the spec, or adding a new one. See the `path` property to learn how add/update operations are distinguished.</summary>
public class MaterialUpdateOperation
{
    /// <summary>JSON pointer (considering the `model` field as root) specifying where to add the material. If it points to a containe...</summary>
    [JsonPropertyName("path")]
    [JsonRequired]
    public required string Path { get; set; }

    [JsonPropertyName("materialData")]
    [JsonRequired]
    public required MaterialResponse MaterialData { get; set; }

    /// <summary>Material spec object that will be used as the base to apply the physical properties passed in `materialData`.</summary>
    [JsonPropertyName("materialSpec")]
    public Dictionary<string, JsonElement>? MaterialSpec { get; set; }

    [JsonPropertyName("reference")]
    public MaterialUpdateOperationReference? Reference { get; set; }

    [JsonPropertyName("materialDataSources")]
    public List<string>? MaterialDataSources { get; set; }

}
