using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class ManualMeshSizing : OneOf_SubmeshRefinementSizing
{
    /// <summary>Schema name: ManualMeshSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL";

    [JsonPropertyName("minimumEdgeLength")]
    public Dimensional_Length? MinimumEdgeLength { get; set; }

    [JsonPropertyName("maximumEdgeLength")]
    public Dimensional_Length? MaximumEdgeLength { get; set; }

    [JsonPropertyName("grading")]
    public OneOf_ManualMeshSizingGrading? Grading { get; set; }

}
