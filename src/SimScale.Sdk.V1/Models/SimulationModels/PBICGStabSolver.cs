using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PBICGStabSolver : OneOf_FluidSolversVelocitySolver, OneOf_FluidSolversVelocityFinalSolver, OneOf_FluidSolversTemperatureSolver, OneOf_FluidSolversTemperatureFinalSolver, OneOf_FluidSolversTurbulentKineticEnergySolver, OneOf_FluidSolversTurbulentKineticEnergyFinalSolver, OneOf_FluidSolversOmegaDissipationRateSolver, OneOf_FluidSolversOmegaDissipationRateFinalSolver, OneOf_FluidSolversEpsilonDissipationRateSolver, OneOf_FluidSolversEpsilonDissipationRateFinalSolver, OneOf_FluidSolversRadiativeIntensityRaySolver, OneOf_FluidSolversVoltageSolver
{
    /// <summary>Schema name: PBICGStabSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PBICGStab";

    /// <summary>Define the absolute tolerance for the residual. The convergence process will be stopped as soon as the residual falls...</summary>
    [JsonPropertyName("absoluteTolerance")]
    public double? AbsoluteTolerance { get; set; }

    /// <summary>Choose the relative tolerance for the residual. The convergence process will be stopped as soon as the ratio of curre...</summary>
    [JsonPropertyName("relativeTolerance")]
    public double? RelativeTolerance { get; set; }

    [JsonPropertyName("preconditioner")]
    public OneOf_PBICGStabSolverPreconditioner? Preconditioner { get; set; }

}
