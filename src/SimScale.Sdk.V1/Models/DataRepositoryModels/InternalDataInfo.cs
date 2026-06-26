using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.DataRepositoryModels;

public class InternalDataInfo : DataInfo
{
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("createdBy")]
    public int? CreatedBy { get; set; }

    [JsonPropertyName("creationTimestamp")]
    public DateTimeOffset? CreationTimestamp { get; set; }

    /// <summary>Data identifier. It is a string composed of the type identifier and a UUID: `data:[UUID]`.</summary>
    [JsonPropertyName("dataId")]
    public string? DataId { get; set; }

    /// <summary>Identifies if a data is - `INTERNAL`: data is stored and managed by `data-repository` service or - `EXTERNAL`: data i...</summary>
    [JsonPropertyName("dataProviderType")]
    public string? DataProviderType { get; set; }

    [JsonPropertyName("dataSize")]
    public long? DataSize { get; set; }

    /// <summary>Reference to a component version. Components are organized into a group hierarchy which serves as a qualification mec...</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    [JsonPropertyName("data_info_type")]
    [JsonRequired]
    public required string DataInfoType { get; set; }

    /// <summary>Identifies the origin of data creation: - `USER_UPLOAD`: data was uploaded or registered directly by a user through t...</summary>
    [JsonPropertyName("origin")]
    public string? Origin { get; set; }

    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    [JsonPropertyName("storageId")]
    public string? StorageId { get; set; }

}
