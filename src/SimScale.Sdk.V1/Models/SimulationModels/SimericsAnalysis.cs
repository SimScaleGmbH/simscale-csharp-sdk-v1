using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SimericsAnalysis : Analysis
{
    /// <summary>Schema name: SimericsAnalysis</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIMERICS_ANALYSIS";

    [JsonPropertyName("isCompressible")]
    public bool? IsCompressible { get; set; }

    [JsonPropertyName("isMulticomponent")]
    public bool? IsMulticomponent { get; set; }

    [JsonPropertyName("isMultiphase")]
    public bool? IsMultiphase { get; set; }

    [JsonPropertyName("isCHT")]
    public bool? IsCHT { get; set; }

    [JsonPropertyName("numberOfPhases")]
    public int? NumberOfPhases { get; set; }

    [JsonPropertyName("cavitationModel")]
    public string? CavitationModel { get; set; }

    /// <summary>Choose a turbulence model for your CFD analysis:No turbulence: LaminarRANS: k-epsilonLearn more.</summary>
    [JsonPropertyName("turbulenceModel")]
    public string? TurbulenceModel { get; set; }

    [JsonPropertyName("timeDependency")]
    public OneOf_SimericsAnalysisTimeDependency? TimeDependency { get; set; }

    [JsonPropertyName("model")]
    public FluidModel? Model { get; set; }

    [JsonPropertyName("materials")]
    public SimericsMaterials? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public FluidInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_SimericsAnalysisBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("advancedConcepts")]
    public AdvancedConcepts? AdvancedConcepts { get; set; }

    [JsonPropertyName("numerics")]
    public FluidNumerics? Numerics { get; set; }

    [JsonPropertyName("simulationControl")]
    public FluidSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("resultControl")]
    public FluidResultControls? ResultControl { get; set; }

    [JsonPropertyName("meshSettings")]
    public OneOf_SimericsAnalysisMeshSettings? MeshSettings { get; set; }

}
