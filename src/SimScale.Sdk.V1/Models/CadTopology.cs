using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CadTopology
{
    [JsonPropertyName("_links")]
    public CollectionLinks? Links { get; set; }

    [JsonPropertyName("_meta")]
    public CollectionMeta? Meta { get; set; }

    [JsonPropertyName("_embedded")]
    public List<EntityDescription>? Embedded { get; set; }

}
