using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class HexDominantSnappy : Algorithm
{
    /// <summary>Schema name: HexDominantSnappy</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HEX_DOMINANT_SNAPPY_V5";

    /// <summary>The meshing mode defines how the mesher should generate the mesh.The Internal mode will create the mesh inside of the...</summary>
    [JsonPropertyName("meshingMode")]
    public string? MeshingMode { get; set; }

    [JsonPropertyName("sizing")]
    public OneOf_HexDominantSnappySizing? Sizing { get; set; }

    /// <summary>This toggle enables the automatic creation of boundary layers at no-slip walls. When toggled on, the meshing is start...</summary>
    [JsonPropertyName("physicsBasedMeshing")]
    public bool? PhysicsBasedMeshing { get; set; }

    /// <summary>Selecting more processor cores might speed up the meshing process. Choosing a smaller computation instance will save...</summary>
    [JsonPropertyName("numOfProcessors")]
    public long? NumOfProcessors { get; set; }

    [JsonPropertyName("maxMeshingRunTime")]
    public Dimensional_Time? MaxMeshingRunTime { get; set; }

    [JsonPropertyName("refinements")]
    public List<OneOf_HexDominantSnappyRefinements>? Refinements { get; set; }

}
