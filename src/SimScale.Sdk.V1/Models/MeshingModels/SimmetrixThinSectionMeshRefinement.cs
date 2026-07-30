using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class SimmetrixThinSectionMeshRefinement : OneOf_SimmetrixMeshingSolidRefinements, OneOf_SimmetrixMeshingFluidRefinements
{
    /// <summary>Schema name: SimmetrixThinSectionMeshRefinement</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIMMETRIX_THIN_SECTION_MESH_REFINEMENT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("distanceType")]
    public OneOf_SimmetrixThinSectionMeshRefinementDistanceType? DistanceType { get; set; }

    [JsonPropertyName("sizingType")]
    public OneOf_SimmetrixThinSectionMeshRefinementSizingType? SizingType { get; set; }

    [JsonPropertyName("surfaceElementType")]
    public string? SurfaceElementType { get; set; }

    [JsonPropertyName("specifyLocalSize")]
    public bool? SpecifyLocalSize { get; set; }

    [JsonPropertyName("maxElementSize")]
    public Dimensional_Length? MaxElementSize { get; set; }

    [JsonPropertyName("sourceTopologicalReference")]
    public TopologicalReference? SourceTopologicalReference { get; set; }

    [JsonPropertyName("destinationTopologicalReference")]
    public TopologicalReference? DestinationTopologicalReference { get; set; }

}
