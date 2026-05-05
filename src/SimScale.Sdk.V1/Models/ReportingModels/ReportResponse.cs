using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ReportResponse
{
    /// <summary>The ID of the report.</summary>
    [JsonPropertyName("reportId")]
    [JsonRequired]
    public required Guid ReportId { get; set; }

    /// <summary>The name of the report.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    /// <summary>The description of the report.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The time the report was created.</summary>
    [JsonPropertyName("createdAt")]
    [JsonRequired]
    public required DateTimeOffset CreatedAt { get; set; }

    /// <summary>The time the report was started.</summary>
    [JsonPropertyName("startedAt")]
    public DateTimeOffset? StartedAt { get; set; }

    /// <summary>The time the report was finished.</summary>
    [JsonPropertyName("finishedAt")]
    public DateTimeOffset? FinishedAt { get; set; }

    /// <summary>Status of the report operation.</summary>
    [JsonPropertyName("status")]
    [JsonRequired]
    public required string Status { get; set; }

    /// <summary>The resultIds the report has been created for.</summary>
    [JsonPropertyName("resultIds")]
    public List<Guid>? ResultIds { get; set; }

    [JsonPropertyName("reportProperties")]
    public ReportProperties? ReportProperties { get; set; }

    [JsonPropertyName("reportFromStateProperties")]
    public ReportFromStateProperties? ReportFromStateProperties { get; set; }

    [JsonPropertyName("download")]
    public DownloadInfo? Download { get; set; }

    /// <summary>Result of a STATISTICS report. Contains one entry per requested part identifier, part group identifier, or cutting pl...</summary>
    [JsonPropertyName("statisticsResult")]
    public Dictionary<string, StatisticsResultEntry>? StatisticsResult { get; set; }

    [JsonPropertyName("failureReason")]
    public JsonElement? FailureReason { get; set; }

}
