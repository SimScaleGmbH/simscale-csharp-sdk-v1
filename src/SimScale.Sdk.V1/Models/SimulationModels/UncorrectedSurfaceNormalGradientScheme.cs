using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class UncorrectedSurfaceNormalGradientScheme : OneOf_SurfaceNormalGradientSchemesForDefault, OneOf_SurfaceNormalGradientSchemesSurfaceNormalGradient_rho, OneOf_SurfaceNormalGradientSchemesSurfaceNormalGradient_pressureRgh, OneOf_SurfaceNormalGradientSchemesSurfaceNormalGradient_rhok
{
    /// <summary>Schema name: UncorrectedSurfaceNormalGradientScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "UNCORRECTED";

}
