using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Data type description in association to file operations</summary>
public class DataTypeFileOperationsDescription
{
    [JsonPropertyName("downloadable")]
    public bool? Downloadable { get; set; }

    [JsonPropertyName("fileFormatGroups")]
    public List<FileFormatGroup>? FileFormatGroups { get; set; }

    [JsonPropertyName("uploadable")]
    public bool? Uploadable { get; set; }

}
