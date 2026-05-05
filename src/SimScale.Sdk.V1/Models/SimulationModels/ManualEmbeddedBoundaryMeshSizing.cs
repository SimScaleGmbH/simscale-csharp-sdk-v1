using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ManualEmbeddedBoundaryMeshSizing : OneOf_EmbeddedBoundaryMeshingSizing
{
    /// <summary>Schema name: ManualEmbeddedBoundaryMeshSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL_EBM_MESH_SIZING";

    [JsonPropertyName("maximumEdgeLength")]
    public Dimensional_Length? MaximumEdgeLength { get; set; }

    [JsonPropertyName("minimumEdgeLength")]
    public Dimensional_Length? MinimumEdgeLength { get; set; }

}
