using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.DataRepositoryModels;

/// <summary>Append operation initialized for an upload session.</summary>
public class UploadSessionAppend
{
    [JsonPropertyName("appendId")]
    public string? AppendId { get; set; }

    [JsonPropertyName("preSignedPutRequest")]
    public PresignedRequest? PreSignedPutRequest { get; set; }

}
