using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GaussLinearUpwindVUnlimitedDivergenceScheme : OneOf_DivergenceSchemesForDefault, OneOf_DivergenceSchemesDiv_Phi_velocity, OneOf_DivergenceSchemesDiv_R, OneOf_DivergenceSchemesDiv_tauMC, OneOf_DivergenceSchemesDiv_velocity
{
    /// <summary>Schema name: GaussLinearUpwindVUnlimitedDivergenceScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GAUSS_LINEARUPWINDV_UNLIMITED";

    /// <summary>This property defines a limiter coefficient for the scheme. 1 ensures boundedness while 0 applies no limiting.</summary>
    [JsonPropertyName("limiterCoefficient")]
    public double? LimiterCoefficient { get; set; }

}
