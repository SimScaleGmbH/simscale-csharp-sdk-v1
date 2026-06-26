using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>High-level description of a file format which makes it suitable for dealing with files on user interfaces.</summary>
public class FileFormat
{
    [JsonPropertyName("fileExtensions")]
    public List<string>? FileExtensions { get; set; }

    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    [JsonPropertyName("multiLanguageName")]
    public Dictionary<string, string>? MultiLanguageName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

}
