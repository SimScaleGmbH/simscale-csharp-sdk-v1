using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.PostprocessingModels;

public class StateParticleTraceAnimationOutputSettings : OneOfStateAnimationOutputSettings
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PARTICLE_TRACE";

    /// <summary>True if any scalarSettings entry in the state has legendVisibilityMode set to AUTO (1) or ALWAYS (2). False if all en...</summary>
    [JsonPropertyName("showLegend")]
    [JsonRequired]
    public required bool ShowLegend { get; set; }

    /// <summary>The frame (time step) at which to render the particle trace animation.</summary>
    [JsonPropertyName("frameIndex")]
    [JsonRequired]
    public required int FrameIndex { get; set; }

    /// <summary>The number of steps to generate for the particle trace animation.</summary>
    [JsonPropertyName("steps")]
    [JsonRequired]
    public required int Steps { get; set; }

}
