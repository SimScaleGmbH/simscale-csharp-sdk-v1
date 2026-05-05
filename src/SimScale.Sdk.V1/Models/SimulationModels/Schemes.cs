using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Schemes
{
    [JsonPropertyName("flux")]
    public FluxSchemes? Flux { get; set; }

    [JsonPropertyName("timeDifferentiation")]
    public TimeDifferentiationSchemes? TimeDifferentiation { get; set; }

    [JsonPropertyName("spatialDiscretization")]
    public SpatialDiscretizationSchemes? SpatialDiscretization { get; set; }

    [JsonPropertyName("gradient")]
    public GradientSchemes? Gradient { get; set; }

    [JsonPropertyName("divergence")]
    public DivergenceSchemes? Divergence { get; set; }

    [JsonPropertyName("laplacian")]
    public LaplacianSchemes? Laplacian { get; set; }

    [JsonPropertyName("interpolation")]
    public InterpolationSchemes? Interpolation { get; set; }

    [JsonPropertyName("surfaceNormalGradient")]
    public SurfaceNormalGradientSchemes? SurfaceNormalGradient { get; set; }

    /// <summary>Whether to use second-order convection scheme, which is less stable but more accurate for a given mesh. If false, fir...</summary>
    [JsonPropertyName("secondOrderConvection")]
    public bool? SecondOrderConvection { get; set; }

}
