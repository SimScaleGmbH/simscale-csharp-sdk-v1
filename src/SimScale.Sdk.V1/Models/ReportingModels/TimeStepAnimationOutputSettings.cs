using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class TimeStepAnimationOutputSettings : OneOfAnimationOutputSettings
{
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    [JsonPropertyName("format")]
    public string Format { get; set; } = "GIF";

    [JsonPropertyName("resolution")]
    [JsonRequired]
    public required ResolutionInfo Resolution { get; set; }

    [JsonPropertyName("frameRate")]
    public int FrameRate { get; set; } = 20;

    [JsonPropertyName("showLegend")]
    public bool ShowLegend { get; set; } = true;

    [JsonPropertyName("showCube")]
    public bool ShowCube { get; set; } = true;

    [JsonPropertyName("backgroundColor")]
    public Color? BackgroundColor { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = "TIME_STEP";

    [JsonPropertyName("fromFrameIndex")]
    public int FromFrameIndex { get; set; } = 0;

    /// <summary>Index of the last frame to include (inclusive). Defaults to the last available frame when not provided.</summary>
    [JsonPropertyName("toFrameIndex")]
    public int? ToFrameIndex { get; set; }

    [JsonPropertyName("skipFrames")]
    public int SkipFrames { get; set; } = 0;

}
