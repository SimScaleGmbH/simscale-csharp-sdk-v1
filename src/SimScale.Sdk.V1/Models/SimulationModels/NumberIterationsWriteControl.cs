using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This option controls how the simulation results are written and how frequently.</summary>
public class NumberIterationsWriteControl : OneOf_FluidSimulationControlWriteControl, OneOf_AreaAverageResultControlWriteControl
{
    /// <summary>This option controls how the simulation results are written and how frequently. Schema name: NumberIterationsWriteCon...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NUMBER_OF_ITERATIONS_STEADY_STATE";

    /// <summary>Specify an interval value that defines the number of iterations between two writes of the result.</summary>
    [JsonPropertyName("writeInterval")]
    public int? WriteInterval { get; set; }

}
