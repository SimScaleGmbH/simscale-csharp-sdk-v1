using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.PostprocessingModels;

public class StateTimeStepAnimationOutputSettings : OneOfStateAnimationOutputSettings
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TIME_STEP";

    /// <summary>True if any scalarSettings entry in the state has legendVisibilityMode set to AUTO (1) or ALWAYS (2). False if all en...</summary>
    [JsonPropertyName("showLegend")]
    [JsonRequired]
    public required bool ShowLegend { get; set; }

    [JsonPropertyName("fromFrameIndex")]
    [JsonRequired]
    public required int FromFrameIndex { get; set; }

    /// <summary>Index of the last frame to include (inclusive).</summary>
    [JsonPropertyName("toFrameIndex")]
    [JsonRequired]
    public required int ToFrameIndex { get; set; }

    [JsonPropertyName("skipFrames")]
    [JsonRequired]
    public required int SkipFrames { get; set; }

}
