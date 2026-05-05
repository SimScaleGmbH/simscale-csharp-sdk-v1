using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ScreenshotReportFromStateProperties : ReportFromStateProperties
{
    [JsonPropertyName("reportType")]
    public string ReportType { get; set; } = "SCREENSHOT";

    [JsonPropertyName("stateMetadata")]
    [JsonRequired]
    public required StateMetadata StateMetadata { get; set; }

    [JsonPropertyName("outputSettings")]
    [JsonRequired]
    public required ScreenshotOutputSettings OutputSettings { get; set; }

}
