using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>A region refinement can be used to refine the mesh in a given area. The refinement area needs to be defined either via a geometry primitive or an existing solid (Hex-dominant only).</summary>
public class RegionRefinementWithLevels
{
    /// <summary>A region refinement can be used to refine the mesh in a given area. The refinement area needs to be defined either vi...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION_LEVELS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("refinement")]
    public OneOf_RegionRefinementWithLevelsRefinement? Refinement { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
