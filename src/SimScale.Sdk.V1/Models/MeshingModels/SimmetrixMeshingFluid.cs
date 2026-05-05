using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class SimmetrixMeshingFluid : Algorithm
{
    /// <summary>Schema name: SimmetrixMeshingFluid</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIMMETRIX_MESHING_FLUID_V16";

    [JsonPropertyName("sizing")]
    public OneOf_SimmetrixMeshingFluidSizing? Sizing { get; set; }

    [JsonPropertyName("refinements")]
    public List<OneOf_SimmetrixMeshingFluidRefinements>? Refinements { get; set; }

    [JsonPropertyName("cellZones")]
    public List<SimmetrixCellZones>? CellZones { get; set; }

    [JsonPropertyName("automaticLayerSettings")]
    public OneOf_SimmetrixMeshingFluidAutomaticLayerSettings? AutomaticLayerSettings { get; set; }

    /// <summary>Physics-based meshing takes setup information like materials, boundary conditions, and source terms into account to s...</summary>
    [JsonPropertyName("physicsBasedMeshing")]
    public bool? PhysicsBasedMeshing { get; set; }

    /// <summary>If Hex element core is activated, the interior of the mesh gets covered by hexahedral elements. The transition to the...</summary>
    [JsonPropertyName("hexCore")]
    public bool? HexCore { get; set; }

    [JsonPropertyName("automaticSweepParameters")]
    public OneOf_SimmetrixMeshingFluidAutomaticSweepParameters? AutomaticSweepParameters { get; set; }

    /// <summary>Selecting more processor cores might speed up the meshing process. Choosing a smaller computation instance will save...</summary>
    [JsonPropertyName("numOfProcessors")]
    public long? NumOfProcessors { get; set; }

    [JsonPropertyName("maxMeshingRunTime")]
    public Dimensional_Time? MaxMeshingRunTime { get; set; }

    [JsonPropertyName("advancedSimmetrixSettings")]
    public AdvancedSimmetrixFluidSettings? AdvancedSimmetrixSettings { get; set; }

}
