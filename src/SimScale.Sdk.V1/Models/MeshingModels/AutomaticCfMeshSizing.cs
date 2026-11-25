using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticCfMeshSizing
{
    /// <summary>Schema name: AutomaticCfMeshSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_CF_MESH_SIZING";

    /// <summary>The fineness controls the overall mesh sizing from coarse (0) to fine (10). The maximum cell size is derived from the...</summary>
    [JsonPropertyName("fineness")]
    public double? Fineness { get; set; }

}
