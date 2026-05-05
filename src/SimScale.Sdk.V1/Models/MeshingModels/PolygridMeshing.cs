using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class PolygridMeshing : Algorithm
{
    /// <summary>Schema name: PolygridMeshing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "POLYGRID_MESHING";

    [JsonPropertyName("sizing")]
    public OneOf_PolygridMeshingSizing? Sizing { get; set; }

    [JsonPropertyName("refinements")]
    public List<OneOf_PolygridMeshingRefinements>? Refinements { get; set; }

    /// <summary>Target number of cells for every cell size level. Higher number of buffer cells ensure smoother cell size transitions...</summary>
    [JsonPropertyName("numberOfBufferCells")]
    public double? NumberOfBufferCells { get; set; }

    /// <summary>Selecting more processor cores might speed up the meshing process. Choosing a smaller computation instance will save...</summary>
    [JsonPropertyName("numOfProcessors")]
    public long? NumOfProcessors { get; set; }

    [JsonPropertyName("maxMeshingRunTime")]
    public Dimensional_Time? MaxMeshingRunTime { get; set; }

}
