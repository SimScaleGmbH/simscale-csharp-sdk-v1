using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>A surface refinement can be used to refine the mesh near the surfaces of assigned faces and/or solids. A surface refinement can also be used to create a cell zone.</summary>
public class SurfaceRefinement
{
    /// <summary>A surface refinement can be used to refine the mesh near the surfaces of assigned faces and/or solids. A surface refi...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_V3";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify surface-wise the minimum refinement level for this surface.</summary>
    [JsonPropertyName("minLevel")]
    public int? MinLevel { get; set; }

    /// <summary>Specify surface-wise the maximum refinement level for this surface.</summary>
    [JsonPropertyName("maxLevel")]
    public int? MaxLevel { get; set; }

    [JsonPropertyName("cellZone")]
    public OneOf_SurfaceRefinementCellZone? CellZone { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
