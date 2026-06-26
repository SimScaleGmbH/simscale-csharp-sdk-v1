using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Report properties as returned by the internal report endpoint that postproc-result-query reads. Its reportProperties uses the full ReportProperties, including the server-resolved resolution hints (cadAssociations, topologyLabelByName) that the public ReportResponse omits. Only the fields the batch job needs are exposed here; the public-facing report fields (status, download, statisticsResult, ...) live on ReportResponse.</summary>
public class InternalReportResponse
{
    [JsonPropertyName("reportProperties")]
    public ReportProperties? ReportProperties { get; set; }

    [JsonPropertyName("reportFromStateProperties")]
    public ReportFromStateProperties? ReportFromStateProperties { get; set; }

}
