using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CollectionLinks
{
    [JsonPropertyName("first")]
    public JsonElement? First { get; set; }

    [JsonPropertyName("prev")]
    public JsonElement? Prev { get; set; }

    [JsonPropertyName("self")]
    public JsonElement? Self { get; set; }

    [JsonPropertyName("next")]
    public JsonElement? Next { get; set; }

    [JsonPropertyName("last")]
    public JsonElement? Last { get; set; }

}
