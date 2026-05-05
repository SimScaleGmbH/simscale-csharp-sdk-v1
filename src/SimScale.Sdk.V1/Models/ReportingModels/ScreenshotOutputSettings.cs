using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ScreenshotOutputSettings
{
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    [JsonPropertyName("format")]
    public string Format { get; set; } = "PNG";

    [JsonPropertyName("resolution")]
    [JsonRequired]
    public required ResolutionInfo Resolution { get; set; }

    /// <summary>Default to the last timestep or frame in the result.</summary>
    [JsonPropertyName("frameIndex")]
    public int? FrameIndex { get; set; }

    [JsonPropertyName("showLegend")]
    public bool ShowLegend { get; set; } = true;

    [JsonPropertyName("showCube")]
    public bool ShowCube { get; set; } = true;

    [JsonPropertyName("backgroundColor")]
    public Color? BackgroundColor { get; set; }

}
