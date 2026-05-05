using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticPolygridMeshSizing : OneOf_PolygridMeshingSizing
{
    /// <summary>Schema name: AutomaticPolygridMeshSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_POLYGRID_MESH_SIZING";

    /// <summary>This parameter determines the fineness of the mesh and affects the overall number of cells.Note: This setting will im...</summary>
    [JsonPropertyName("fineness")]
    public double? Fineness { get; set; }

    /// <summary>Physics-based meshing takes setup information into account to size the immersed mesh accordingly. Users can expect au...</summary>
    [JsonPropertyName("physicsBasedMeshingIBM")]
    public bool? PhysicsBasedMeshingIBM { get; set; }

}
