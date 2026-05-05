using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This option controls how the simulation results are written and how frequently.</summary>
public class CustomResolution : OneOf_ForcesMomentsResultControlWriteControl, OneOf_TransientResultControlWriteControl, OneOf_StatisticalAveragingResultControlV2SamplingInterval, OneOf_ProbePointsResultControlWriteControl
{
    /// <summary>This option controls how the simulation results are written and how frequently. Schema name: CustomResolution</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_RESOLUTION";

    [JsonPropertyName("writeInterval")]
    public Dimensional_Time? WriteInterval { get; set; }

}
