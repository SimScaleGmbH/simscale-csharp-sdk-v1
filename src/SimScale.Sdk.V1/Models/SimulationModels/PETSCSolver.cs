using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PETSCSolver : OneOf_SolidNumericsSolver
{
    /// <summary>Schema name: PETSCSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PETSC";

    /// <summary>Set the threshold value for convergence detection for the relative convergence criteria.</summary>
    [JsonPropertyName("convergenceThreshold")]
    public double? ConvergenceThreshold { get; set; }

    /// <summary>Set the maximum number of iterations for the iterative solver. If set to 0 PETSC sets an estimate of the maximum numb...</summary>
    [JsonPropertyName("maxIterations")]
    public int? MaxIterations { get; set; }

    [JsonPropertyName("advancedPetscSettings")]
    public AdvancedPETSCSettings? AdvancedPetscSettings { get; set; }

}
