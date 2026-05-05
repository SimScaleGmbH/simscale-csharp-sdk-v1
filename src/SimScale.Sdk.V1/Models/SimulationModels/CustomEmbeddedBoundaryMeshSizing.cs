using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomEmbeddedBoundaryMeshSizing : OneOf_EmbeddedBoundaryMeshingSizing
{
    /// <summary>Schema name: CustomEmbeddedBoundaryMeshSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_EBM_MESH_SIZING";

    [JsonPropertyName("numCellsPerDirection")]
    public NumberOfCellsPerDirection? NumCellsPerDirection { get; set; }

    /// <summary>Number of refinement levels to refine in the vicinity of all CAD surfaces.</summary>
    [JsonPropertyName("numRefinementLevels")]
    public int? NumRefinementLevels { get; set; }

}
