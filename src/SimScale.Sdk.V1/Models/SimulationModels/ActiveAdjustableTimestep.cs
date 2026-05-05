using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This option activates an adjustable time step. The time step is being modified according to the Courant number.</summary>
public class ActiveAdjustableTimestep : OneOf_FluidSimulationControlAdjustableTimestep
{
    /// <summary>This option activates an adjustable time step. The time step is being modified according to the Courant number. Schem...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ACTIVE_TIMESTEP";

    /// <summary>This option defines a maximum Courant number. The resulting time step should resolve relevant transient effects with...</summary>
    [JsonPropertyName("maximalCourantNumber")]
    public double? MaximalCourantNumber { get; set; }

    /// <summary>This option defines a maximum time step length which may not be exceeded when the time step is adapted during runtime.</summary>
    [JsonPropertyName("maximalStep")]
    public double? MaximalStep { get; set; }

    /// <summary>Define a maximum Courant number based on the interface velocity.</summary>
    [JsonPropertyName("maxAlphaCo")]
    public double? MaxAlphaCo { get; set; }

}
