using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class MoveContentRequest
{
    [JsonPropertyName("entries")]
    [JsonRequired]
    public required List<ResourceToMove> Entries { get; set; }

    [JsonPropertyName("to")]
    [JsonRequired]
    public required ResourceLocation To { get; set; }

}
