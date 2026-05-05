using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class SimmetrixMeshingSolid : Algorithm
{
    /// <summary>Schema name: SimmetrixMeshingSolid</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIMMETRIX_MESHING_SOLID";

    [JsonPropertyName("sizing")]
    public OneOf_SimmetrixMeshingSolidSizing? Sizing { get; set; }

    [JsonPropertyName("refinements")]
    public List<OneOf_SimmetrixMeshingSolidRefinements>? Refinements { get; set; }

    [JsonPropertyName("automaticSweepParameters")]
    public OneOf_SimmetrixMeshingSolidAutomaticSweepParameters? AutomaticSweepParameters { get; set; }

    /// <summary>Selecting more processor cores might speed up the meshing process. Choosing a smaller computation instance will save...</summary>
    [JsonPropertyName("numOfProcessors")]
    public long? NumOfProcessors { get; set; }

    [JsonPropertyName("maxMeshingRunTime")]
    public Dimensional_Time? MaxMeshingRunTime { get; set; }

    [JsonPropertyName("advancedSimmetrixSettings")]
    public AdvancedSimmetrixSolidSettings? AdvancedSimmetrixSettings { get; set; }

}
