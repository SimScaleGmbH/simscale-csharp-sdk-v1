using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class EmbeddedBoundaryMeshing
{
    [JsonPropertyName("sizing")]
    public OneOf_EmbeddedBoundaryMeshingSizing? Sizing { get; set; }

    /// <summary>Target number of cells for every cell size level. Higher number of buffer cells ensure smoother cell size transitions...</summary>
    [JsonPropertyName("numberOfBufferCells")]
    public double? NumberOfBufferCells { get; set; }

    [JsonPropertyName("refinements")]
    public List<OneOf_EmbeddedBoundaryMeshingRefinements>? Refinements { get; set; }

}
