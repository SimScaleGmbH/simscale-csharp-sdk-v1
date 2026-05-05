using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MumpsDirectSolver : OneOf_MarcLinearSolverSettingsLinearSolver
{
    /// <summary>Schema name: MumpsDirectSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MUMPS_DIRECT";

    /// <summary>Automatically applies small artificial stiffness to unconstrained bodies to prevent numerical singularities during th...</summary>
    [JsonPropertyName("autoConstrain")]
    public bool? AutoConstrain { get; set; }

}
