using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Encapsulates all generic metadata about a component at a particular version.</summary>
public class ComponentVersionMetadata
{
    /// <summary>Reference to a component version. Components are organized into a group hierarchy which serves as a qualification mec...</summary>
    [JsonPropertyName("componentVersionReference")]
    public string? ComponentVersionReference { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("multiLanguageDescription")]
    public Dictionary<string, string>? MultiLanguageDescription { get; set; }

    [JsonPropertyName("multiLanguageName")]
    public Dictionary<string, string>? MultiLanguageName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Possible states of a component version.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

}
