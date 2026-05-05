using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.PostprocessingModels;

public class StateResponse
{
    /// <summary>The unique identifier for the state (default, manually or automatically saved).</summary>
    [JsonPropertyName("stateUuid")]
    [JsonRequired]
    public required Guid StateUuid { get; set; }

    /// <summary>State name, as provided in the workbench.</summary>
    [JsonPropertyName("stateName")]
    public string? StateName { get; set; }

    /// <summary>Description of the state, as provided in the workbench.</summary>
    [JsonPropertyName("stateDescription")]
    public string? StateDescription { get; set; }

    [JsonPropertyName("screenshotOutputSettings")]
    public StateScreenshotOutputSettings? ScreenshotOutputSettings { get; set; }

    [JsonPropertyName("animationOutputSettings")]
    public OneOfStateAnimationOutputSettings? AnimationOutputSettings { get; set; }

}
