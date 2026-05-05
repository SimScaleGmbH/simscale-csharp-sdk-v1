using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.PostprocessingModels;

public class StateScreenshotOutputSettings
{
    /// <summary>True if any scalarSettings entry in the state has legendVisibilityMode set to AUTO (1) or ALWAYS (2). False if all en...</summary>
    [JsonPropertyName("showLegend")]
    [JsonRequired]
    public required bool ShowLegend { get; set; }

    /// <summary>The frame index from the state.</summary>
    [JsonPropertyName("frameIndex")]
    [JsonRequired]
    public required int FrameIndex { get; set; }

}
