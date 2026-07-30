using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>The global min/max report configuration as returned in a report response: the scalar field whose extremes were sought and the solution steps that were scanned.</summary>
public class StatisticsGlobalMinMaxReportPropertiesPublic : ReportPropertiesPublic
{
    [JsonPropertyName("reportType")]
    public string ReportType { get; set; } = "STATISTICS_GLOBAL_MIN_MAX";

    [JsonPropertyName("scalarField")]
    [JsonRequired]
    public required ScalarField ScalarField { get; set; }

    [JsonPropertyName("steps")]
    [JsonRequired]
    public required StepSelector Steps { get; set; }

}
