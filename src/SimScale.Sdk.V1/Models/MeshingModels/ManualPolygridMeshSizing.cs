using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class ManualPolygridMeshSizing : OneOf_PolygridMeshingSizing
{
    /// <summary>Schema name: ManualPolygridMeshSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL_POLYGRID_MESH_SIZING";

    [JsonPropertyName("maximumEdgeLength")]
    public Dimensional_Length? MaximumEdgeLength { get; set; }

    [JsonPropertyName("minimumEdgeLength")]
    public Dimensional_Length? MinimumEdgeLength { get; set; }

    /// <summary>Physics-based meshing takes setup information into account to size the immersed mesh accordingly. Users can expect au...</summary>
    [JsonPropertyName("physicsBasedMeshingIBM")]
    public bool? PhysicsBasedMeshingIBM { get; set; }

}
