using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This option activates an adjustable time step. The time step is being modified according to the Courant number.</summary>
public class InactiveAdjustableTimestep : OneOf_FluidSimulationControlAdjustableTimestep
{
    /// <summary>This option activates an adjustable time step. The time step is being modified according to the Courant number. Schem...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INACTIVE_TIMESTEP";

}
