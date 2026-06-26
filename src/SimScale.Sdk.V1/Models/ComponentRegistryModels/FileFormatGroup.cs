using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>A group of related file formats.</summary>
public class FileFormatGroup
{
    [JsonPropertyName("fileFormats")]
    public List<FileFormat>? FileFormats { get; set; }

    [JsonPropertyName("multiLanguageName")]
    public Dictionary<string, string>? MultiLanguageName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

}
