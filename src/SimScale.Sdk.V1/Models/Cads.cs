using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.CadModels;

namespace SimScale.Sdk.V1.Models;

public class Cads
{
    [JsonPropertyName("_links")]
    public CollectionLinks? Links { get; set; }

    [JsonPropertyName("_meta")]
    public CollectionMeta? Meta { get; set; }

    [JsonPropertyName("_embedded")]
    public List<Cad>? Embedded { get; set; }

}
