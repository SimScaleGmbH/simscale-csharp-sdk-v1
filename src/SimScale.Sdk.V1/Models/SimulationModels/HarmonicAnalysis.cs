using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HarmonicAnalysis : Analysis
{
    /// <summary>Schema name: HarmonicAnalysis</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HARMONIC_ANALYSIS";

    [JsonPropertyName("connectionGroups")]
    public List<Contact>? ConnectionGroups { get; set; }

    [JsonPropertyName("connectors")]
    public List<OneOf_HarmonicAnalysisConnectors>? Connectors { get; set; }

    [JsonPropertyName("elementTechnology")]
    public SolidElementTechnology? ElementTechnology { get; set; }

    [JsonPropertyName("globalPhysics")]
    public SolidGlobalPhysics? GlobalPhysics { get; set; }

    [JsonPropertyName("model")]
    public SolidModel? Model { get; set; }

    [JsonPropertyName("materials")]
    public List<SolidMaterial>? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public SolidInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_HarmonicAnalysisBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("numerics")]
    public SolidNumerics? Numerics { get; set; }

    [JsonPropertyName("simulationControl")]
    public SolidSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("resultControl")]
    public SolidResultControl? ResultControl { get; set; }

    [JsonPropertyName("meshOrder")]
    public string? MeshOrder { get; set; }

}
