using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ScreenshotReportProperties : ReportProperties
{
    [JsonPropertyName("reportType")]
    public string ReportType { get; set; } = "SCREENSHOT";

    [JsonPropertyName("modelSettings")]
    [JsonRequired]
    public required ModelSettings ModelSettings { get; set; }

    [JsonPropertyName("filters")]
    public Filters? Filters { get; set; }

    [JsonPropertyName("cameraSettings")]
    [JsonRequired]
    public required OneOfCameraSettings CameraSettings { get; set; }

    [JsonPropertyName("outputSettings")]
    [JsonRequired]
    public required ScreenshotOutputSettings OutputSettings { get; set; }

}
