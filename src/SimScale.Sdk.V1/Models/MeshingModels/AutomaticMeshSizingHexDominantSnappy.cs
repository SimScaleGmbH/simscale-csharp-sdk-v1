using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticMeshSizingHexDominantSnappy : OneOf_HexDominantSnappySizing
{
    /// <summary>Schema name: AutomaticMeshSizingHexDominantSnappy</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC";

    /// <summary>This parameter determines the fineness of the mesh and affects the overall number of cells. It is recommended to star...</summary>
    [JsonPropertyName("fineness")]
    public string? Fineness { get; set; }

}
