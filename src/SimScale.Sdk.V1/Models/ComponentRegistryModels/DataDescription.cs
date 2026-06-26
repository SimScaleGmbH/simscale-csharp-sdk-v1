using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Description of a single data.</summary>
public class DataDescription
{
    /// <summary>Identifies if a data is - `INTERNAL`: data is stored and managed by `data-repository` service or - `EXTERNAL`: data i...</summary>
    [JsonPropertyName("dataProviderType")]
    public string? DataProviderType { get; set; }

    [JsonPropertyName("dataTypeFilter")]
    public JsonElement? DataTypeFilter { get; set; }

    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("multiLanguageDoc")]
    public Dictionary<string, string>? MultiLanguageDoc { get; set; }

    [JsonPropertyName("multiLanguageLabel")]
    public Dictionary<string, string>? MultiLanguageLabel { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("parameters")]
    public List<ParameterDescription>? Parameters { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

}
