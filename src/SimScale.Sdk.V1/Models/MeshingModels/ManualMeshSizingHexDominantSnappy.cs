using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class ManualMeshSizingHexDominantSnappy : OneOf_HexDominantSnappySizing
{
    /// <summary>Schema name: ManualMeshSizingHexDominantSnappy</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL";

    [JsonPropertyName("minimumEdgeLength")]
    public Dimensional_Length? MinimumEdgeLength { get; set; }

    [JsonPropertyName("maximumEdgeLength")]
    public Dimensional_Length? MaximumEdgeLength { get; set; }

}
