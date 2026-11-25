using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This option controls how the simulation results are written and how frequently.</summary>
public class SynchronizeWithFieldOutputWriteControl : OneOf_AreaIntegralResultControlWriteControl, OneOf_ForceMomentCoefficientsResultControlWriteControl, OneOf_ForcesMomentsResultControlWriteControl, OneOf_AreaAverageResultControlWriteControl, OneOf_ProbePointsResultControlWriteControl, OneOf_ScalarTransportResultControlWriteControl
{
    /// <summary>This option controls how the simulation results are written and how frequently. Schema name: SynchronizeWithFieldOutp...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OUTPUT_TIME";

    [JsonPropertyName("writeInterval")]
    public double? WriteInterval { get; set; }

}
