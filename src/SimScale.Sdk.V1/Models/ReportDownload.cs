using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class ReportDownload
{
    /// <summary>The result format. Valid values include `OPEN_FOAM`, `ENSIGHT_GOLD`, `PVD`, `VTM`, `CSV`.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The uncompressed size of the result content.</summary>
    [JsonPropertyName("uncompressedSizeInBytes")]
    public long? UncompressedSizeInBytes { get; set; }

    /// <summary>URL for downloading the result content.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The compression used for the result download archive.</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

}
