using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Data for fetching information about component groups. Contains all properties which are accessible by clients.</summary>
public class ComponentGroupMetadata
{
    /// <summary>Reference to a component group. Components are organized into a group hierarchy which serves as a qualification mecha...</summary>
    [JsonPropertyName("componentGroupReference")]
    public string? ComponentGroupReference { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("hasChildren")]
    public bool? HasChildren { get; set; }

    [JsonPropertyName("multiLanguageDescription")]
    public Dictionary<string, string>? MultiLanguageDescription { get; set; }

    [JsonPropertyName("multiLanguageName")]
    public Dictionary<string, string>? MultiLanguageName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Possible states of a component group.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

}
