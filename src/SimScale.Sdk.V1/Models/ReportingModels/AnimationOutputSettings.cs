using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class AnimationOutputSettings
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

}
