using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.DataRepositoryModels;

/// <summary>Initialized upload session.</summary>
public class UploadSession
{
    [JsonPropertyName("storageId")]
    public string? StorageId { get; set; }

}
