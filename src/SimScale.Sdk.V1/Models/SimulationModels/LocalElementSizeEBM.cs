using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class LocalElementSizeEBM : OneOf_EmbeddedBoundaryMeshingRefinements
{
    /// <summary>Schema name: LocalElementSizeEBM</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LOCAL_SIZING_EBM";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("maxElementSize")]
    public Dimensional_Length? MaxElementSize { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
