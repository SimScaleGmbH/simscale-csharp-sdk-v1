using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class LocalElementSizeCfMesh
{
    /// <summary>Schema name: LocalElementSizeCfMesh</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LOCAL_SIZING_CF_MESH";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("maxElementSize")]
    public Dimensional_Length? MaxElementSize { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
