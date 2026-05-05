using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GradientSchemes
{
    [JsonPropertyName("forDefault")]
    public OneOf_GradientSchemesForDefault? ForDefault { get; set; }

    [JsonPropertyName("grad_pressure")]
    public OneOf_GradientSchemesGrad_pressure? GradPressure { get; set; }

    [JsonPropertyName("grad_velocity")]
    public OneOf_GradientSchemesGrad_velocity? GradVelocity { get; set; }

    [JsonPropertyName("grad_pressureRgh")]
    public OneOf_GradientSchemesGrad_pressureRgh? GradPressurergh { get; set; }

    [JsonPropertyName("grad_density")]
    public OneOf_GradientSchemesGrad_density? GradDensity { get; set; }

    [JsonPropertyName("grad_enthalpy")]
    public OneOf_GradientSchemesGrad_enthalpy? GradEnthalpy { get; set; }

    [JsonPropertyName("grad_internalEnergy")]
    public OneOf_GradientSchemesGrad_internalEnergy? GradInternalenergy { get; set; }

    [JsonPropertyName("grad_turbulentKineticEnergy")]
    public OneOf_GradientSchemesGrad_turbulentKineticEnergy? GradTurbulentkineticenergy { get; set; }

    [JsonPropertyName("grad_epsilonDissipationRate")]
    public OneOf_GradientSchemesGrad_epsilonDissipationRate? GradEpsilondissipationrate { get; set; }

    [JsonPropertyName("grad_omegaDissipationRate")]
    public OneOf_GradientSchemesGrad_omegaDissipationRate? GradOmegadissipationrate { get; set; }

    [JsonPropertyName("grad_nuTilda")]
    public OneOf_GradientSchemesGrad_nuTilda? GradNutilda { get; set; }

    [JsonPropertyName("grad_temperature")]
    public OneOf_GradientSchemesGrad_temperature? GradTemperature { get; set; }

    [JsonPropertyName("grad_rhok")]
    public OneOf_GradientSchemesGrad_rhok? GradRhok { get; set; }

}
