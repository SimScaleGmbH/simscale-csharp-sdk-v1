using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class LaplacianSchemes
{
    [JsonPropertyName("forDefault")]
    public OneOf_LaplacianSchemesForDefault? ForDefault { get; set; }

    [JsonPropertyName("laplacian_NuEff_velocity")]
    public OneOf_LaplacianSchemesLaplacian_NuEff_velocity? LaplacianNueffVelocity { get; set; }

    [JsonPropertyName("laplacian_1A_U_pressure")]
    public OneOf_LaplacianSchemesLaplacian_1A_U_pressure? Laplacian1aUPressure { get; set; }

    [JsonPropertyName("laplacian_Nu_velocity")]
    public OneOf_LaplacianSchemesLaplacian_Nu_velocity? LaplacianNuVelocity { get; set; }

    [JsonPropertyName("laplacian_DREff_R")]
    public OneOf_LaplacianSchemesLaplacian_DREff_R? LaplacianDreffR { get; set; }

    [JsonPropertyName("laplacian_DnuTildaEff_nuTilda")]
    public OneOf_LaplacianSchemesLaplacian_DnuTildaEff_nuTilda? LaplacianDnutildaeffNutilda { get; set; }

    [JsonPropertyName("laplacian_DkEff_turbulentKineticEnergy")]
    public OneOf_LaplacianSchemesLaplacian_DkEff_turbulentKineticEnergy? LaplacianDkeffTurbulentkineticenergy { get; set; }

    [JsonPropertyName("laplacian_alphaEff_enthalpy")]
    public OneOf_LaplacianSchemesLaplacian_alphaEff_enthalpy? LaplacianAlphaeffEnthalpy { get; set; }

    [JsonPropertyName("laplacian_alpha_enthalpy")]
    public OneOf_LaplacianSchemesLaplacian_alpha_enthalpy? LaplacianAlphaEnthalpy { get; set; }

    [JsonPropertyName("laplacian_muEff_velocity")]
    public OneOf_LaplacianSchemesLaplacian_muEff_velocity? LaplacianMueffVelocity { get; set; }

    [JsonPropertyName("laplacian_alphaEff_internalEnergy")]
    public OneOf_LaplacianSchemesLaplacian_alphaEff_internalEnergy? LaplacianAlphaeffInternalenergy { get; set; }

    [JsonPropertyName("laplacian_rhorAUf_pressureRgh")]
    public OneOf_LaplacianSchemesLaplacian_rhorAUf_pressureRgh? LaplacianRhoraufPressurergh { get; set; }

    [JsonPropertyName("laplacian_DepsilonEff_epsilonDissipationRate")]
    public OneOf_LaplacianSchemesLaplacian_DepsilonEff_epsilonDissipationRate? LaplacianDepsiloneffEpsilondissipationrate { get; set; }

    [JsonPropertyName("laplacian_DomegaEff_omegaDissipationRate")]
    public OneOf_LaplacianSchemesLaplacian_DomegaEff_omegaDissipationRate? LaplacianDomegaeffOmegadissipationrate { get; set; }

    [JsonPropertyName("laplacian_rAUf_pressure")]
    public OneOf_LaplacianSchemesLaplacian_rAUf_pressure? LaplacianRaufPressure { get; set; }

    [JsonPropertyName("laplacian_DT_passiveScalar")]
    public OneOf_LaplacianSchemesLaplacian_DT_passiveScalar? LaplacianDtPassivescalar { get; set; }

    [JsonPropertyName("laplacian_Dp_pressure")]
    public OneOf_LaplacianSchemesLaplacian_Dp_pressure? LaplacianDpPressure { get; set; }

    [JsonPropertyName("laplacian_rhorAUf_pressure")]
    public OneOf_LaplacianSchemesLaplacian_rhorAUf_pressure? LaplacianRhoraufPressure { get; set; }

    [JsonPropertyName("laplacian_rho_1_A_U_pressure")]
    public OneOf_LaplacianSchemesLaplacian_rho_1_A_U_pressure? LaplacianRho1AUPressure { get; set; }

    [JsonPropertyName("laplacian_mut_velocity")]
    public OneOf_LaplacianSchemesLaplacian_mut_velocity? LaplacianMutVelocity { get; set; }

    [JsonPropertyName("laplacian_alphaEff_temperature")]
    public OneOf_LaplacianSchemesLaplacian_alphaEff_temperature? LaplacianAlphaeffTemperature { get; set; }

    [JsonPropertyName("laplacian_rAUf_pressureRgh")]
    public OneOf_LaplacianSchemesLaplacian_rAUf_pressureRgh? LaplacianRaufPressurergh { get; set; }

}
