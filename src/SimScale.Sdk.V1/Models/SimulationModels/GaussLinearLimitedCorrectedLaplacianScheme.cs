using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GaussLinearLimitedCorrectedLaplacianScheme : OneOf_LaplacianSchemesForDefault, OneOf_LaplacianSchemesLaplacian_NuEff_velocity, OneOf_LaplacianSchemesLaplacian_1A_U_pressure, OneOf_LaplacianSchemesLaplacian_Nu_velocity, OneOf_LaplacianSchemesLaplacian_DREff_R, OneOf_LaplacianSchemesLaplacian_DnuTildaEff_nuTilda, OneOf_LaplacianSchemesLaplacian_DkEff_turbulentKineticEnergy, OneOf_LaplacianSchemesLaplacian_alphaEff_enthalpy, OneOf_LaplacianSchemesLaplacian_alpha_enthalpy, OneOf_LaplacianSchemesLaplacian_muEff_velocity, OneOf_LaplacianSchemesLaplacian_alphaEff_internalEnergy, OneOf_LaplacianSchemesLaplacian_rhorAUf_pressureRgh, OneOf_LaplacianSchemesLaplacian_DepsilonEff_epsilonDissipationRate, OneOf_LaplacianSchemesLaplacian_DomegaEff_omegaDissipationRate, OneOf_LaplacianSchemesLaplacian_rAUf_pressure, OneOf_LaplacianSchemesLaplacian_DT_passiveScalar, OneOf_LaplacianSchemesLaplacian_Dp_pressure, OneOf_LaplacianSchemesLaplacian_rhorAUf_pressure, OneOf_LaplacianSchemesLaplacian_rho_1_A_U_pressure, OneOf_LaplacianSchemesLaplacian_mut_velocity, OneOf_LaplacianSchemesLaplacian_alphaEff_temperature, OneOf_LaplacianSchemesLaplacian_rAUf_pressureRgh
{
    /// <summary>Schema name: GaussLinearLimitedCorrectedLaplacianScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GAUSS_LINEAR_LIMITED_CORRECTED";

    /// <summary>This property defines a limiter coefficient for the scheme:0: no correction, equivalent to the uncorrected scheme1: f...</summary>
    [JsonPropertyName("limiterCoefficient")]
    public double? LimiterCoefficient { get; set; }

}
