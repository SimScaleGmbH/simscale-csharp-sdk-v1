using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.DataRepositoryModels;

/// <summary>Request to start appending one chunk to an initialized upload session.</summary>
public class StartUploadSessionAppendRequest
{
    [JsonPropertyName("size")]
    public long? Size { get; set; }

}
