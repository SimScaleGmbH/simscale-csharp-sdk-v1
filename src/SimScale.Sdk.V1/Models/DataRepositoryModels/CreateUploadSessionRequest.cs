using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.DataRepositoryModels;

/// <summary>Request to initialize an upload session backed by pre-signed URLs.</summary>
public class CreateUploadSessionRequest
{
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Reference to a component version. Components are organized into a group hierarchy which serves as a qualification mec...</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

}
