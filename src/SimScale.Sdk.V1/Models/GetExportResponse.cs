using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class GetExportResponse
{
    [JsonPropertyName("exportId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid ExportId { get; set; }

    /// <summary>RUNNING - Export is still in progress DONE - Export is done and ready for download FAILED - Export failed, please ret...</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The temporary url for downloading the exported result, only set when status is DONE.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Timestamp that the url will be expired, only set when status is DONE. Note that this timestamp is not a guarantee, if...</summary>
    [JsonPropertyName("urlExpiresAt")]
    public string? UrlExpiresAt { get; set; }

    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

}
