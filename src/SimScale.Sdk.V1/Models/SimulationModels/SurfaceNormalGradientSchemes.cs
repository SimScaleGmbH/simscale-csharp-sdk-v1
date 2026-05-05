using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SurfaceNormalGradientSchemes
{
    [JsonPropertyName("forDefault")]
    public OneOf_SurfaceNormalGradientSchemesForDefault? ForDefault { get; set; }

    [JsonPropertyName("surfaceNormalGradient_rho")]
    public OneOf_SurfaceNormalGradientSchemesSurfaceNormalGradient_rho? SurfacenormalgradientRho { get; set; }

    [JsonPropertyName("surfaceNormalGradient_pressureRgh")]
    public OneOf_SurfaceNormalGradientSchemesSurfaceNormalGradient_pressureRgh? SurfacenormalgradientPressurergh { get; set; }

    [JsonPropertyName("surfaceNormalGradient_rhok")]
    public OneOf_SurfaceNormalGradientSchemesSurfaceNormalGradient_rhok? SurfacenormalgradientRhok { get; set; }

}
