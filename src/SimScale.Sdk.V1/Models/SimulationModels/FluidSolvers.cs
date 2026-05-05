using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidSolvers
{
    [JsonPropertyName("phaseFractionSolver")]
    public MULESSolver? PhaseFractionSolver { get; set; }

    [JsonPropertyName("velocitySolver")]
    public OneOf_FluidSolversVelocitySolver? VelocitySolver { get; set; }

    [JsonPropertyName("velocityFinalSolver")]
    public OneOf_FluidSolversVelocityFinalSolver? VelocityFinalSolver { get; set; }

    [JsonPropertyName("densitySolver")]
    public OneOf_FluidSolversDensitySolver? DensitySolver { get; set; }

    [JsonPropertyName("densityFinalSolver")]
    public OneOf_FluidSolversDensityFinalSolver? DensityFinalSolver { get; set; }

    [JsonPropertyName("pressureSolver")]
    public OneOf_FluidSolversPressureSolver? PressureSolver { get; set; }

    [JsonPropertyName("pressureFinalSolver")]
    public OneOf_FluidSolversPressureFinalSolver? PressureFinalSolver { get; set; }

    [JsonPropertyName("temperatureSolver")]
    public OneOf_FluidSolversTemperatureSolver? TemperatureSolver { get; set; }

    [JsonPropertyName("temperatureFinalSolver")]
    public OneOf_FluidSolversTemperatureFinalSolver? TemperatureFinalSolver { get; set; }

    [JsonPropertyName("pressureRghSolver")]
    public OneOf_FluidSolversPressureRghSolver? PressureRghSolver { get; set; }

    [JsonPropertyName("pressureRghFinalSolver")]
    public OneOf_FluidSolversPressureRghFinalSolver? PressureRghFinalSolver { get; set; }

    [JsonPropertyName("solidEnthalpySolver")]
    public OneOf_FluidSolversSolidEnthalpySolver? SolidEnthalpySolver { get; set; }

    [JsonPropertyName("solidEnthalpyFinalSolver")]
    public OneOf_FluidSolversSolidEnthalpyFinalSolver? SolidEnthalpyFinalSolver { get; set; }

    [JsonPropertyName("enthalpySolver")]
    public OneOf_FluidSolversEnthalpySolver? EnthalpySolver { get; set; }

    [JsonPropertyName("enthalpyFinalSolver")]
    public OneOf_FluidSolversEnthalpyFinalSolver? EnthalpyFinalSolver { get; set; }

    [JsonPropertyName("internalEnergySolver")]
    public OneOf_FluidSolversInternalEnergySolver? InternalEnergySolver { get; set; }

    [JsonPropertyName("internalEnergyFinalSolver")]
    public OneOf_FluidSolversInternalEnergyFinalSolver? InternalEnergyFinalSolver { get; set; }

    [JsonPropertyName("turbulentKineticEnergySolver")]
    public OneOf_FluidSolversTurbulentKineticEnergySolver? TurbulentKineticEnergySolver { get; set; }

    [JsonPropertyName("turbulentKineticEnergyFinalSolver")]
    public OneOf_FluidSolversTurbulentKineticEnergyFinalSolver? TurbulentKineticEnergyFinalSolver { get; set; }

    [JsonPropertyName("nuTildaSolver")]
    public OneOf_FluidSolversNuTildaSolver? NuTildaSolver { get; set; }

    [JsonPropertyName("nuTildaFinalSolver")]
    public OneOf_FluidSolversNuTildaFinalSolver? NuTildaFinalSolver { get; set; }

    [JsonPropertyName("omegaDissipationRateSolver")]
    public OneOf_FluidSolversOmegaDissipationRateSolver? OmegaDissipationRateSolver { get; set; }

    [JsonPropertyName("omegaDissipationRateFinalSolver")]
    public OneOf_FluidSolversOmegaDissipationRateFinalSolver? OmegaDissipationRateFinalSolver { get; set; }

    [JsonPropertyName("epsilonDissipationRateSolver")]
    public OneOf_FluidSolversEpsilonDissipationRateSolver? EpsilonDissipationRateSolver { get; set; }

    [JsonPropertyName("epsilonDissipationRateFinalSolver")]
    public OneOf_FluidSolversEpsilonDissipationRateFinalSolver? EpsilonDissipationRateFinalSolver { get; set; }

    [JsonPropertyName("passiveScalarSolver")]
    public OneOf_FluidSolversPassiveScalarSolver? PassiveScalarSolver { get; set; }

    [JsonPropertyName("radiativeIntensityRaySolver")]
    public OneOf_FluidSolversRadiativeIntensityRaySolver? RadiativeIntensityRaySolver { get; set; }

    [JsonPropertyName("internalNetRadiativeHeatFluxSolver")]
    public PBICGStabSolver? InternalNetRadiativeHeatFluxSolver { get; set; }

    [JsonPropertyName("specificHumiditySolver")]
    public OneOf_FluidSolversSpecificHumiditySolver? SpecificHumiditySolver { get; set; }

    [JsonPropertyName("voltageSolver")]
    public OneOf_FluidSolversVoltageSolver? VoltageSolver { get; set; }

}
