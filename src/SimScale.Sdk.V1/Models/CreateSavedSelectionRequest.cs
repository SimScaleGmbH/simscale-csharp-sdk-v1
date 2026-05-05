using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CreateSavedSelectionRequest
{
    /// <summary>The name of the saved selection.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    [JsonPropertyName("type")]
    [JsonRequired]
    public required string Type { get; set; }

    /// <summary>The entities included in the saved selection.</summary>
    [JsonPropertyName("entities")]
    [JsonRequired]
    public required List<string> Entities { get; set; }

}
