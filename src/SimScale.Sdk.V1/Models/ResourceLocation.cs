using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Specify the destination to which the resource will be moved/copied</summary>
public class ResourceLocation
{
    [JsonPropertyName("spaceId")]
    [JsonRequired]
    public required Guid SpaceId { get; set; }

    /// <summary>If missing, the resource will be moved/copied to the root of the Space</summary>
    [JsonPropertyName("parentFolderId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid ParentFolderId { get; set; }

}
