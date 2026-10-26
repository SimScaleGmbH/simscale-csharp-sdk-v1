using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Surface custom sizing refines the mesh on the selected faces. The maximum edge length is the target cell size on the faces, the minimum element size is the lower bound for the automatic refinement of curvature and small features on them. Use it for faces of interest, for example inlets, outlets or walls with small details.</summary>
public class LocalElementSizeCfMesh
{
    /// <summary>Surface custom sizing refines the mesh on the selected faces. The maximum edge length is the target cell size on the...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LOCAL_SIZING_CF_MESH";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("maxElementSize")]
    public Dimensional_Length? MaxElementSize { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
