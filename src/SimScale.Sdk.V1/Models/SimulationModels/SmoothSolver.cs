using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SmoothSolver : OneOf_TrueSemiImplicitSolver, OneOf_FluidSolversVelocitySolver, OneOf_FluidSolversVelocityFinalSolver, OneOf_FluidSolversDensitySolver, OneOf_FluidSolversDensityFinalSolver, OneOf_FluidSolversPressureSolver, OneOf_FluidSolversPressureFinalSolver, OneOf_FluidSolversTemperatureSolver, OneOf_FluidSolversTemperatureFinalSolver, OneOf_FluidSolversPressureRghSolver, OneOf_FluidSolversPressureRghFinalSolver, OneOf_FluidSolversSolidEnthalpySolver, OneOf_FluidSolversSolidEnthalpyFinalSolver, OneOf_FluidSolversEnthalpySolver, OneOf_FluidSolversEnthalpyFinalSolver, OneOf_FluidSolversInternalEnergySolver, OneOf_FluidSolversInternalEnergyFinalSolver, OneOf_FluidSolversTurbulentKineticEnergySolver, OneOf_FluidSolversTurbulentKineticEnergyFinalSolver, OneOf_FluidSolversNuTildaSolver, OneOf_FluidSolversNuTildaFinalSolver, OneOf_FluidSolversOmegaDissipationRateSolver, OneOf_FluidSolversOmegaDissipationRateFinalSolver, OneOf_FluidSolversEpsilonDissipationRateSolver, OneOf_FluidSolversEpsilonDissipationRateFinalSolver, OneOf_FluidSolversPassiveScalarSolver, OneOf_FluidSolversRadiativeIntensityRaySolver, OneOf_FluidSolversSpecificHumiditySolver, OneOf_FluidSolversVoltageSolver
{
    /// <summary>Schema name: SmoothSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SMOOTH";

    /// <summary>Define the absolute tolerance for the residual. The convergence process will be stopped as soon as the residual falls...</summary>
    [JsonPropertyName("absoluteTolerance")]
    public double? AbsoluteTolerance { get; set; }

    /// <summary>Choose the relative tolerance for the residual. The convergence process will be stopped as soon as the ratio of curre...</summary>
    [JsonPropertyName("relativeTolerance")]
    public double? RelativeTolerance { get; set; }

    /// <summary>Choose a smoother for your solver.</summary>
    [JsonPropertyName("smoother")]
    public string? Smoother { get; set; }

    /// <summary>Define the numbers of sweeps.</summary>
    [JsonPropertyName("numSweeps")]
    public int? NumSweeps { get; set; }

}
