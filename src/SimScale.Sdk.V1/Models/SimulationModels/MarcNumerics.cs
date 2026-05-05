using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcNumerics
{
    [JsonPropertyName("linearSolverSettings")]
    public MarcLinearSolverSettings? LinearSolverSettings { get; set; }

    [JsonPropertyName("nonlinearSolverSettings")]
    public MarcNonlinearSolverSettings? NonlinearSolverSettings { get; set; }

}
