using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

public class DocumentationPage
{
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("multiLanguageContent")]
    public Dictionary<string, string>? MultiLanguageContent { get; set; }

    [JsonPropertyName("multiLanguageTitle")]
    public Dictionary<string, string>? MultiLanguageTitle { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

}
