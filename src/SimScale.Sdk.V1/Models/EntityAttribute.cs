using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class EntityAttribute
{
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

}
