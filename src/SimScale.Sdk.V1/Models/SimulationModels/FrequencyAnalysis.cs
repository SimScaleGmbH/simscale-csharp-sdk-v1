using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FrequencyAnalysis : Analysis
{
    /// <summary>Schema name: FrequencyAnalysis</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FREQUENCY_ANALYSIS";

    [JsonPropertyName("connectionGroups")]
    public List<Contact>? ConnectionGroups { get; set; }

    [JsonPropertyName("connectors")]
    public List<OneOf_FrequencyAnalysisConnectors>? Connectors { get; set; }

    [JsonPropertyName("elementTechnology")]
    public SolidElementTechnology? ElementTechnology { get; set; }

    [JsonPropertyName("model")]
    public SolidModel? Model { get; set; }

    [JsonPropertyName("materials")]
    public List<SolidMaterial>? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public SolidInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_FrequencyAnalysisBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("numerics")]
    public SolidNumerics? Numerics { get; set; }

    [JsonPropertyName("simulationControl")]
    public SolidSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("resultControl")]
    public SolidResultControl? ResultControl { get; set; }

    [JsonPropertyName("meshOrder")]
    public string? MeshOrder { get; set; }

}
