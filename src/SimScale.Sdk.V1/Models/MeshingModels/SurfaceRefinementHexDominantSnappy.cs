using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>A surface refinement can be used to refine the mesh near the surfaces of assigned faces and/or solids. A surface refinement can also be used to create a cell zone.</summary>
public class SurfaceRefinementHexDominantSnappy : OneOf_HexDominantSnappyRefinements
{
    /// <summary>A surface refinement can be used to refine the mesh near the surfaces of assigned faces and/or solids. A surface refi...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_HEX_DOMINANT_SNAPPY_V3";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("minLength")]
    public Dimensional_Length? MinLength { get; set; }

    [JsonPropertyName("maxLength")]
    public Dimensional_Length? MaxLength { get; set; }

    [JsonPropertyName("cellZone")]
    public OneOf_SurfaceRefinementHexDominantSnappyCellZone? CellZone { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
