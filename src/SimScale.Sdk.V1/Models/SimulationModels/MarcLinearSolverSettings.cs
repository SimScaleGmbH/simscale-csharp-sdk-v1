using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcLinearSolverSettings
{
    [JsonPropertyName("linearSolver")]
    public OneOf_MarcLinearSolverSettingsLinearSolver? LinearSolver { get; set; }

}
