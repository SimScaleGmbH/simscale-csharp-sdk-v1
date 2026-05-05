using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidModel
{
    [JsonPropertyName("turbulentSchmidtNumber")]
    public double? TurbulentSchmidtNumber { get; set; }

    [JsonPropertyName("diffusionCoefficients")]
    public List<Dimensional_KinematicViscosity>? DiffusionCoefficients { get; set; }

    [JsonPropertyName("deltaCoefficient")]
    public OneOf_FluidModelDeltaCoefficient? DeltaCoefficient { get; set; }

    [JsonPropertyName("gravity")]
    public DimensionalVector_Acceleration? Gravity { get; set; }

    [JsonPropertyName("surfaceTension")]
    public Dimensional_SurfaceTension? SurfaceTension { get; set; }

}
