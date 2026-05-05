using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PCGSolver : OneOf_FluidSolversDensitySolver, OneOf_FluidSolversDensityFinalSolver, OneOf_FluidSolversPressureSolver, OneOf_FluidSolversPressureFinalSolver, OneOf_FluidSolversPressureRghSolver, OneOf_FluidSolversPressureRghFinalSolver, OneOf_FluidSolversSolidEnthalpySolver, OneOf_FluidSolversSolidEnthalpyFinalSolver
{
    /// <summary>Schema name: PCGSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PCG";

    /// <summary>Define the absolute tolerance for the residual. The convergence process will be stopped as soon as the residual falls...</summary>
    [JsonPropertyName("absoluteTolerance")]
    public double? AbsoluteTolerance { get; set; }

    /// <summary>Choose the relative tolerance for the residual. The convergence process will be stopped as soon as the ratio of curre...</summary>
    [JsonPropertyName("relativeTolerance")]
    public double? RelativeTolerance { get; set; }

    [JsonPropertyName("preconditioner")]
    public OneOf_PCGSolverPreconditioner? Preconditioner { get; set; }

}
