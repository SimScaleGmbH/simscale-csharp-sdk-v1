using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This option controls how the simulation results are written and how frequently.</summary>
public class RunTimeWriteControl : OneOf_FluidSimulationControlWriteControl
{
    /// <summary>This option controls how the simulation results are written and how frequently. Schema name: RunTimeWriteControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RUNTIME";

    [JsonPropertyName("writeInterval")]
    public Dimensional_Time? WriteInterval { get; set; }

}
