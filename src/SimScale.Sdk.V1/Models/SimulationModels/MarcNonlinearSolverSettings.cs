using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcNonlinearSolverSettings
{
    /// <summary>Determines how the global stiffness matrix is updated during the nonlinear equilibrium search. This choice balances t...</summary>
    [JsonPropertyName("iterativeProcedure")]
    public string? IterativeProcedure { get; set; }

    /// <summary>Controls how the current state of stress in the material (geometric stiffness) influences the overall stiffness matri...</summary>
    [JsonPropertyName("initialStressStiffnessContribution")]
    public string? InitialStressStiffnessContribution { get; set; }

    /// <summary>Defines the upper limit for the number of additional equilibrium iterations (recycles) within a single increment. If...</summary>
    [JsonPropertyName("maxNumberOfRecycles")]
    public int? MaxNumberOfRecycles { get; set; }

    /// <summary>Defines the lower limit of the number of equilibrium recycles within a single increment. Setting this above 1 ensures...</summary>
    [JsonPropertyName("minNumberOfRecycles")]
    public int? MinNumberOfRecycles { get; set; }

    [JsonPropertyName("convergenceMethod")]
    public OneOf_MarcNonlinearSolverSettingsConvergenceMethod? ConvergenceMethod { get; set; }

}
