using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>A region refinement can be used to refine the mesh in a given area. The refinement area needs to be defined either via an existing solid or a geometry primitive.</summary>
public class RegionRefinementWithLength : OneOf_SimmetrixMeshingSolidRefinements, OneOf_SimmetrixMeshingFluidRefinements, OneOf_SimmetrixMeshingElectromagneticsRefinements, OneOf_HexDominantSnappyRefinements
{
    /// <summary>A region refinement can be used to refine the mesh in a given area. The refinement area needs to be defined either vi...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION_LENGTH";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("refinement")]
    public OneOf_RegionRefinementWithLengthRefinement? Refinement { get; set; }

    [JsonPropertyName("curvature")]
    public OneOf_RegionRefinementWithLengthCurvature? Curvature { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
