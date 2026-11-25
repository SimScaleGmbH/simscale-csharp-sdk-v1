using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class SimmetrixExtrusionMeshRefinement : OneOf_SimmetrixMeshingFluidRefinements, OneOf_SimmetrixMeshingSolidRefinements
{
    /// <summary>Schema name: SimmetrixExtrusionMeshRefinement</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIMMETRIX_EXTRUSION_MESH_REFINEMENT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sizingType")]
    public OneOf_SimmetrixExtrusionMeshRefinementSizingType? SizingType { get; set; }

    [JsonPropertyName("surfaceElementType")]
    public string? SurfaceElementType { get; set; }

    [JsonPropertyName("specifyLocalSize")]
    public bool? SpecifyLocalSize { get; set; }

    [JsonPropertyName("maxElementSize")]
    public Dimensional_Length? MaxElementSize { get; set; }

    /// <summary>Enables the grading of the extrusion elements, starting from either side of the extrusion. The first layer has to be...</summary>
    [JsonPropertyName("enableGrading")]
    public bool? EnableGrading { get; set; }

    [JsonPropertyName("firstElementThickness")]
    public Dimensional_Length? FirstElementThickness { get; set; }

    /// <summary>The Growth rate defines the thickness ratio between adjacent boundary layer cells. It needs to be always greater than...</summary>
    [JsonPropertyName("growthRate")]
    public double? GrowthRate { get; set; }

    /// <summary>Side defines which side of the extrusion will have the specified First layer thickness. The options are Start face, E...</summary>
    [JsonPropertyName("gradingSide")]
    public string? GradingSide { get; set; }

    [JsonPropertyName("sourceTopologicalReference")]
    public TopologicalReference? SourceTopologicalReference { get; set; }

    [JsonPropertyName("destinationTopologicalReference")]
    public TopologicalReference? DestinationTopologicalReference { get; set; }

}
