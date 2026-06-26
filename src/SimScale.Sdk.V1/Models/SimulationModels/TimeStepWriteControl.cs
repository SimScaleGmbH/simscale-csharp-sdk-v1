using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This option controls how the simulation results are written and how frequently.</summary>
public class TimeStepWriteControl : OneOf_ForceMomentCoefficientsResultControlWriteControl, OneOf_AreaIntegralResultControlWriteControl, OneOf_AreaAverageResultControlWriteControl, OneOf_ScalarTransportResultControlWriteControl, OneOf_ProbePointsResultControlWriteControl, OneOf_FluidSimulationControlWriteControl, OneOf_ForcesMomentsResultControlWriteControl
{
    /// <summary>This option controls how the simulation results are written and how frequently. Schema name: TimeStepWriteControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TIME_STEP";

    /// <summary>Specify an interval value that defines the number of time steps between two writes of the result.</summary>
    [JsonPropertyName("writeInterval")]
    public int? WriteInterval { get; set; }

}
