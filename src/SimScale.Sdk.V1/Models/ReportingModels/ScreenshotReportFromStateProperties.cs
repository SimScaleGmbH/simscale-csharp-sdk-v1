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

    [JsonPropertyName("cameraOverride")]
    public OneOfCameraSettings? CameraOverride { get; set; }

    /// <summary>When false, the rendered screenshot is not registered back into the project (ephemeral). Defaults to true.</summary>
    [JsonPropertyName("persist")]
    public bool? Persist { get; set; }

}
