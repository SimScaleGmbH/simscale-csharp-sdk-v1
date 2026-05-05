using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Reference identifiers of the provided material and its material group</summary>
public class MaterialUpdateOperationReference
{
    /// <summary>Identifier of the material group</summary>
    [JsonPropertyName("materialGroupId")]
    public string? MaterialGroupId { get; set; }

    /// <summary>Identifier of the material</summary>
    [JsonPropertyName("materialId")]
    public string? MaterialId { get; set; }

    [JsonPropertyName("interpolationParameters")]
    public InterpolationParameters? InterpolationParameters { get; set; }

}
