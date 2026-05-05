using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DivergenceSchemes
{
    [JsonPropertyName("forDefault")]
    public OneOf_DivergenceSchemesForDefault? ForDefault { get; set; }

    [JsonPropertyName("div_Phi_velocity")]
    public OneOf_DivergenceSchemesDiv_Phi_velocity? DivPhiVelocity { get; set; }

    [JsonPropertyName("div_Phi_kineticEnergy")]
    public OneOf_DivergenceSchemesDiv_Phi_kineticEnergy? DivPhiKineticenergy { get; set; }

    [JsonPropertyName("div_Phi_enthalpy")]
    public OneOf_DivergenceSchemesDiv_Phi_enthalpy? DivPhiEnthalpy { get; set; }

    [JsonPropertyName("div_Phi_internalEnergy")]
    public OneOf_DivergenceSchemesDiv_Phi_internalEnergy? DivPhiInternalenergy { get; set; }

    [JsonPropertyName("div_Phiv_pressure")]
    public OneOf_DivergenceSchemesDiv_Phiv_pressure? DivPhivPressure { get; set; }

    [JsonPropertyName("div_Phi_turbulentKineticEnergy")]
    public OneOf_DivergenceSchemesDiv_Phi_turbulentKineticEnergy? DivPhiTurbulentkineticenergy { get; set; }

    [JsonPropertyName("div_NuEff_dev_T_grad_velocity")]
    public GaussLinearDivergenceScheme? DivNueffDevTGradVelocity { get; set; }

    [JsonPropertyName("div_MuEff_dev2_T_grad_velocity")]
    public GaussLinearDivergenceScheme? DivMueffDev2TGradVelocity { get; set; }

    [JsonPropertyName("div_Phi_omegaDissipationRate")]
    public OneOf_DivergenceSchemesDiv_Phi_omegaDissipationRate? DivPhiOmegadissipationrate { get; set; }

    [JsonPropertyName("div_Phi_epsilonDissipationRate")]
    public OneOf_DivergenceSchemesDiv_Phi_epsilonDissipationRate? DivPhiEpsilondissipationrate { get; set; }

    [JsonPropertyName("div_R")]
    public OneOf_DivergenceSchemesDiv_R? DivR { get; set; }

    [JsonPropertyName("div_Phi_R")]
    public OneOf_DivergenceSchemesDiv_Phi_R? DivPhiR { get; set; }

    [JsonPropertyName("div_Phi_nuTilda")]
    public OneOf_DivergenceSchemesDiv_Phi_nuTilda? DivPhiNutilda { get; set; }

    [JsonPropertyName("div_Phi_temperature")]
    public OneOf_DivergenceSchemesDiv_Phi_temperature? DivPhiTemperature { get; set; }

    [JsonPropertyName("div_Phi_passiveScalar")]
    public OneOf_DivergenceSchemesDiv_Phi_passiveScalar? DivPhiPassivescalar { get; set; }

    [JsonPropertyName("div_tauMC")]
    public OneOf_DivergenceSchemesDiv_tauMC? DivTaumc { get; set; }

    [JsonPropertyName("div_phid_pressure")]
    public OneOf_DivergenceSchemesDiv_phid_pressure? DivPhidPressure { get; set; }

    [JsonPropertyName("div_velocity")]
    public OneOf_DivergenceSchemesDiv_velocity? DivVelocity { get; set; }

    [JsonPropertyName("div_phi_Ekp")]
    public OneOf_DivergenceSchemesDiv_phi_Ekp? DivPhiEkp { get; set; }

    [JsonPropertyName("div_phirb_alpha")]
    public OneOf_DivergenceSchemesDiv_phirb_alpha? DivPhirbAlpha { get; set; }

    [JsonPropertyName("div_muEff_dev_T_grad_velocity")]
    public GaussLinearDivergenceScheme? DivMueffDevTGradVelocity { get; set; }

    [JsonPropertyName("div_phi_alpha")]
    public OneOf_DivergenceSchemesDiv_phi_alpha? DivPhiAlpha { get; set; }

    [JsonPropertyName("div_rhoPhi_velocity")]
    public OneOf_DivergenceSchemesDiv_rhoPhi_velocity? DivRhophiVelocity { get; set; }

}
