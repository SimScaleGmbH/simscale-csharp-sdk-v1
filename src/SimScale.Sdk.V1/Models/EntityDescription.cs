using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class EntityDescription
{
    /// <summary>The internal name of the entity.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The topological entity class (body or face).</summary>
    [JsonPropertyName("class")]
    public string? @Class { get; set; }

    [JsonPropertyName("originateFrom")]
    public List<OriginalEntityReference>? OriginateFrom { get; set; }

}
