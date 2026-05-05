using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class ManualCfMeshSizing
{
    /// <summary>Schema name: ManualCfMeshSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL_CF_MESH_SIZING";

    [JsonPropertyName("maximumEdgeLength")]
    public Dimensional_Length? MaximumEdgeLength { get; set; }

    [JsonPropertyName("minimumEdgeLength")]
    public Dimensional_Length? MinimumEdgeLength { get; set; }

}
