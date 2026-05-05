using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GAMGSolver : OneOf_PCGSolverPreconditioner, OneOf_FluidSolversDensitySolver, OneOf_FluidSolversDensityFinalSolver, OneOf_FluidSolversPressureSolver, OneOf_FluidSolversPressureFinalSolver, OneOf_FluidSolversPressureRghSolver, OneOf_FluidSolversPressureRghFinalSolver, OneOf_FluidSolversSolidEnthalpySolver, OneOf_FluidSolversSolidEnthalpyFinalSolver, OneOf_FluidSolversVoltageSolver
{
    /// <summary>Schema name: GAMGSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GAMG";

    /// <summary>Define the absolute tolerance for the residual. The convergence process will be stopped as soon as the residual falls...</summary>
    [JsonPropertyName("absoluteTolerance")]
    public double? AbsoluteTolerance { get; set; }

    /// <summary>Choose the relative tolerance for the residual. The convergence process will be stopped as soon as the ratio of curre...</summary>
    [JsonPropertyName("relativeTolerance")]
    public double? RelativeTolerance { get; set; }

    /// <summary>Choose a smoother for your solver.</summary>
    [JsonPropertyName("smoother")]
    public string? Smoother { get; set; }

    [JsonPropertyName("numPreSweeps")]
    public int? NumPreSweeps { get; set; }

    [JsonPropertyName("numPostSweeps")]
    public int? NumPostSweeps { get; set; }

    [JsonPropertyName("cacheAgglomerationOn")]
    public bool? CacheAgglomerationOn { get; set; }

    [JsonPropertyName("numCellsCoarsestLevel")]
    public int? NumCellsCoarsestLevel { get; set; }

    [JsonPropertyName("numMergeLevels")]
    public int? NumMergeLevels { get; set; }

}
