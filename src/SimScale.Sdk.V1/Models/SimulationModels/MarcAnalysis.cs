using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcAnalysis : Analysis
{
    /// <summary>Schema name: MarcAnalysis</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MARC_ANALYSIS";

    /// <summary>Choose whether thermal effects should be included in the analysis, such as heat conduction, thermal loads, temperatur...</summary>
    [JsonPropertyName("thermalEffects")]
    public bool? ThermalEffects { get; set; }

    [JsonPropertyName("connectionGroups")]
    public List<MarcConnectionGroup>? ConnectionGroups { get; set; }

    [JsonPropertyName("connectors")]
    public List<RemotePointConnectionMarc>? Connectors { get; set; }

    [JsonPropertyName("elementTechnology")]
    public MarcElementTechnology? ElementTechnology { get; set; }

    [JsonPropertyName("materials")]
    public List<MarcMaterial>? Materials { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_MarcAnalysisBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("numerics")]
    public MarcNumerics? Numerics { get; set; }

    [JsonPropertyName("loadSteps")]
    public List<LoadStep>? LoadSteps { get; set; }

    [JsonPropertyName("simulationControl")]
    public MarcSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("resultControl")]
    public MarcResultControl? ResultControl { get; set; }

}
