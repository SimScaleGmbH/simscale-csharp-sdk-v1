using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ShapeAnimationOutputSettings : OneOfAnimationOutputSettings
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
    public string? Type { get; set; }

    /// <summary>Frame (or frequency) for which to create a mode shape animation.Default is the last frame in the result.</summary>
    [JsonPropertyName("frameIndex")]
    public int? FrameIndex { get; set; }

    /// <summary>The number of steps to generate for the shape animation</summary>
    [JsonPropertyName("steps")]
    public int Steps { get; set; } = 30;

    /// <summary>How to deform the model for the animation. FULL implies animating from the original, undeformed shape to the maximum...</summary>
    [JsonPropertyName("range")]
    public string Range { get; set; } = "FULL";

}
