using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GaussLinearUpwindLimitedGradDivergenceScheme : OneOf_DivergenceSchemesDiv_Phi_velocity, OneOf_DivergenceSchemesDiv_Phi_kineticEnergy, OneOf_DivergenceSchemesDiv_Phi_enthalpy, OneOf_DivergenceSchemesDiv_Phi_internalEnergy, OneOf_DivergenceSchemesDiv_Phiv_pressure, OneOf_DivergenceSchemesDiv_Phi_turbulentKineticEnergy, OneOf_DivergenceSchemesDiv_Phi_omegaDissipationRate, OneOf_DivergenceSchemesDiv_Phi_epsilonDissipationRate, OneOf_DivergenceSchemesDiv_Phi_R, OneOf_DivergenceSchemesDiv_Phi_nuTilda, OneOf_DivergenceSchemesDiv_Phi_temperature, OneOf_DivergenceSchemesDiv_Phi_passiveScalar, OneOf_DivergenceSchemesDiv_phid_pressure, OneOf_DivergenceSchemesDiv_phi_Ekp, OneOf_DivergenceSchemesDiv_rhoPhi_velocity
{
    /// <summary>Schema name: GaussLinearUpwindLimitedGradDivergenceScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GAUSS_LINEARUPWIND_LIMITEDGRAD";

}
