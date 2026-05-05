using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SparseIterative : OneOf_MarcLinearSolverSettingsLinearSolver
{
    /// <summary>Schema name: SparseIterative</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SPARSE_ITERATIVE";

    /// <summary>Selects the preconditioning technique used to accelerate convergence of the iterative solver.Incomplete Cholesky: Rec...</summary>
    [JsonPropertyName("preconditioner")]
    public string? Preconditioner { get; set; }

    /// <summary>Defines what Marc should do if the iterative solver fails to converge within the allowed number of iterations for a g...</summary>
    [JsonPropertyName("nonConvergenceAction")]
    public string? NonConvergenceAction { get; set; }

    /// <summary>The relative residual tolerance used to determine when the iterative solver has found a sufficiently accurate solutio...</summary>
    [JsonPropertyName("convergenceTolerance")]
    public double? ConvergenceTolerance { get; set; }

}
