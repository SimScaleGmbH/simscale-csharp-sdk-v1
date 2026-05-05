using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticAnalysis : Analysis
{
    /// <summary>Schema name: ElectromagneticAnalysis</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELECTROMAGNETIC_ANALYSIS";

    [JsonPropertyName("model")]
    public OneOf_ElectromagneticAnalysisModel? Model { get; set; }

    [JsonPropertyName("materials")]
    public List<ElectromagneticMaterial>? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public ElectromagneticInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("coils")]
    public List<Coil>? Coils { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_ElectromagneticAnalysisBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("advancedConcepts")]
    public ElectromagneticAdvancedConcepts? AdvancedConcepts { get; set; }

    [JsonPropertyName("resultControl")]
    public ElectromagneticResultControl? ResultControl { get; set; }

    [JsonPropertyName("numerics")]
    public ElectromagneticNumerics? Numerics { get; set; }

    [JsonPropertyName("simulationControl")]
    public ElectromagneticSimulationControl? SimulationControl { get; set; }

}
