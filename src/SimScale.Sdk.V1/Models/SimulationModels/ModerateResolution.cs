using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Output will be written every 4 time steps.</summary>
public class ModerateResolution : OneOf_StatisticalAveragingResultControlV2SamplingInterval, OneOf_ProbePointsResultControlWriteControl, OneOf_TransientResultControlWriteControl, OneOf_ForcesMomentsResultControlWriteControl
{
    /// <summary>Output will be written every 4 time steps. Schema name: ModerateResolution</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MODERATE_RESOLUTION";

}
