using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Output will be written every 2 time steps.</summary>
public class HighResolution : OneOf_ForcesMomentsResultControlWriteControl, OneOf_TransientResultControlWriteControl, OneOf_StatisticalAveragingResultControlV2SamplingInterval, OneOf_ProbePointsResultControlWriteControl
{
    /// <summary>Output will be written every 2 time steps. Schema name: HighResolution</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HIGH_RESOLUTION";

}
