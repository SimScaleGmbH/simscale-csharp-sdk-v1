using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class LimitedSurfaceNormalGradientScheme : OneOf_SurfaceNormalGradientSchemesForDefault, OneOf_SurfaceNormalGradientSchemesSurfaceNormalGradient_rho, OneOf_SurfaceNormalGradientSchemesSurfaceNormalGradient_pressureRgh, OneOf_SurfaceNormalGradientSchemesSurfaceNormalGradient_rhok
{
    /// <summary>Schema name: LimitedSurfaceNormalGradientScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LIMITED";

    /// <summary>This property defines a limiter coefficient for the scheme:0: no correction, equivalent to the uncorrected scheme1: f...</summary>
    [JsonPropertyName("limiterCoefficient")]
    public double? LimiterCoefficient { get; set; }

}
