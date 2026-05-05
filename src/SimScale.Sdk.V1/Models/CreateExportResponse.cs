using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class CreateExportResponse
{
    [JsonPropertyName("exportId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid ExportId { get; set; }

    /// <summary>The result to be exported</summary>
    [JsonPropertyName("resultId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid ResultId { get; set; }

    /// <summary>The format to export to</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>RUNNING - Export is still in progress DONE - Export is done and ready for download FAILED - Export failed, please ret...</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

}
