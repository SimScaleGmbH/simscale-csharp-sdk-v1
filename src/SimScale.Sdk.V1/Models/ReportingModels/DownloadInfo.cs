using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class DownloadInfo
{
    /// <summary>The result format.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The uncompressed size of the report result content.</summary>
    [JsonPropertyName("uncompressedSizeInBytes")]
    public long? UncompressedSizeInBytes { get; set; }

    /// <summary>URL for downloading the report result content.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The compression used for the report result download archive.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

}
