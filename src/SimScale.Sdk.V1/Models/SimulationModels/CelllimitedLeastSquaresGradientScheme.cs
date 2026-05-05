using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CelllimitedLeastSquaresGradientScheme : OneOf_GradientSchemesForDefault, OneOf_GradientSchemesGrad_pressure, OneOf_GradientSchemesGrad_velocity, OneOf_GradientSchemesGrad_pressureRgh, OneOf_GradientSchemesGrad_density, OneOf_GradientSchemesGrad_enthalpy, OneOf_GradientSchemesGrad_internalEnergy, OneOf_GradientSchemesGrad_turbulentKineticEnergy, OneOf_GradientSchemesGrad_epsilonDissipationRate, OneOf_GradientSchemesGrad_omegaDissipationRate, OneOf_GradientSchemesGrad_nuTilda, OneOf_GradientSchemesGrad_temperature, OneOf_GradientSchemesGrad_rhok
{
    /// <summary>Schema name: CelllimitedLeastSquaresGradientScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CELLLIMITED_LEASTSQUARES";

    /// <summary>This property defines a limiter coefficient for the scheme. 1 ensures boundedness while 0 applies no limiting.</summary>
    [JsonPropertyName("limiterCoefficient")]
    public double? LimiterCoefficient { get; set; }

}
