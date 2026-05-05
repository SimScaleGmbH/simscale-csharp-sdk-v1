using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class CustomPolygridMeshSizing : OneOf_PolygridMeshingSizing
{
    /// <summary>Schema name: CustomPolygridMeshSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_POLYGRID_MESH_SIZING";

    [JsonPropertyName("numCellsPerDirection")]
    public NumberOfCellsPerDirection? NumCellsPerDirection { get; set; }

    /// <summary>Number of refinement levels to refine in the vicinity of all CAD surfaces.</summary>
    [JsonPropertyName("numRefinementLevels")]
    public int? NumRefinementLevels { get; set; }

    /// <summary>Physics-based meshing takes setup information into account to size the immersed mesh accordingly. Users can expect au...</summary>
    [JsonPropertyName("physicsBasedMeshingIBM")]
    public bool? PhysicsBasedMeshingIBM { get; set; }

}
