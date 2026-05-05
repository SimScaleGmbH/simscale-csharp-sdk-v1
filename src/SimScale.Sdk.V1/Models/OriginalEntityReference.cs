using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class OriginalEntityReference
{
    /// <summary>The path from the root of the model.</summary>
    [JsonPropertyName("path")]
    public List<BodyPath>? Path { get; set; }

    /// <summary>The original body name.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>The original entity name.</summary>
    [JsonPropertyName("entity")]
    public string? Entity { get; set; }

    /// <summary>The attributes assigned to the entity.</summary>
    [JsonPropertyName("attributeList")]
    public List<EntityAttribute>? AttributeList { get; set; }

}
