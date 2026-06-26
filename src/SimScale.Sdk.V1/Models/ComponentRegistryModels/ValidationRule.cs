using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Validation rule defined on top of a value model. Each rule consists of one or more cases.</summary>
public class ValidationRule
{
    [JsonPropertyName("cases")]
    public List<ValidationRuleCase>? Cases { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("multiLanguageDescription")]
    public Dictionary<string, string>? MultiLanguageDescription { get; set; }

    [JsonPropertyName("multiLanguageName")]
    public Dictionary<string, string>? MultiLanguageName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("valueReference")]
    public JsonElement? ValueReference { get; set; }

}
