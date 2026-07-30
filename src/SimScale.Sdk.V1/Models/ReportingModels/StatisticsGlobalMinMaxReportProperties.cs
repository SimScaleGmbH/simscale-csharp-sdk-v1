using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Configuration for a global min/max report: find the smallest and largest value of one scalar field across the entire model, over the selected steps, reporting each extreme's value, coordinates, part, and the step it occurred at.</summary>
public class StatisticsGlobalMinMaxReportProperties : ReportProperties
{
    [JsonPropertyName("reportType")]
    public string ReportType { get; set; } = "STATISTICS_GLOBAL_MIN_MAX";

    [JsonPropertyName("scalarField")]
    [JsonRequired]
    public required ScalarField ScalarField { get; set; }

    [JsonPropertyName("steps")]
    [JsonRequired]
    public required StepSelector Steps { get; set; }

    /// <summary>Mesh-part-name to user-facing label mapping, used to report the extreme's part by label rather than internal mesh name.</summary>
    [JsonPropertyName("topologyLabelByName")]
    public Dictionary<string, string>? TopologyLabelByName { get; set; }

}
