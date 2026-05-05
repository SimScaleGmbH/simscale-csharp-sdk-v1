using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PardisoDirectSolver : OneOf_MarcLinearSolverSettingsLinearSolver
{
    /// <summary>Schema name: PardisoDirectSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PARDISO_DIRECT";

}
