using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class SimmetrixMeshingElectromagnetics : Algorithm
{
    /// <summary>Schema name: SimmetrixMeshingElectromagnetics</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIMMETRIX_MESHING_ELECTROMAGNETICS";

    [JsonPropertyName("sizing")]
    public OneOf_SimmetrixMeshingElectromagneticsSizing? Sizing { get; set; }

    [JsonPropertyName("refinements")]
    public List<OneOf_SimmetrixMeshingElectromagneticsRefinements>? Refinements { get; set; }

    /// <summary>Selecting more processor cores might speed up the meshing process. Choosing a smaller computation instance will save...</summary>
    [JsonPropertyName("numOfProcessors")]
    public long? NumOfProcessors { get; set; }

    [JsonPropertyName("maxMeshingRunTime")]
    public Dimensional_Time? MaxMeshingRunTime { get; set; }

    [JsonPropertyName("advancedSimmetrixSettings")]
    public AdvancedSimmetrixEmSettings? AdvancedSimmetrixSettings { get; set; }

}
