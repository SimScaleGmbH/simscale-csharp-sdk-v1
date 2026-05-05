using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.PostprocessingModels;

public class StateShapeAnimationOutputSettings : OneOfStateAnimationOutputSettings
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SHAPE";

    /// <summary>True if any scalarSettings entry in the state has legendVisibilityMode set to AUTO (1) or ALWAYS (2). False if all en...</summary>
    [JsonPropertyName("showLegend")]
    [JsonRequired]
    public required bool ShowLegend { get; set; }

    /// <summary>Frame (or frequency) for which to create a mode shape animation.</summary>
    [JsonPropertyName("frameIndex")]
    [JsonRequired]
    public required int FrameIndex { get; set; }

    /// <summary>The number of steps to generate for the shape animation.</summary>
    [JsonPropertyName("steps")]
    [JsonRequired]
    public required int Steps { get; set; }

    /// <summary>How to deform the model for the animation. FULL (x0 -&gt; +xmax -&gt; x0 -&gt; -xmax -&gt; x0), HALF (x0 -&gt; +xmax...</summary>
    [JsonPropertyName("range")]
    [JsonRequired]
    public required string Range { get; set; }

}
