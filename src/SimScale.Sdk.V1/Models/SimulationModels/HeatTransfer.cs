using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HeatTransfer : Analysis
{
    /// <summary>Schema name: HeatTransfer</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HEAT_TRANSFER";

    [JsonPropertyName("timeDependency")]
    public OneOf_HeatTransferTimeDependency? TimeDependency { get; set; }

    /// <summary>Choose if your analysis should feature any kind of nonlinearity like physical contacts, nonlinear materials as hypere...</summary>
    [JsonPropertyName("nonLinearAnalysis")]
    public bool? NonLinearAnalysis { get; set; }

    [JsonPropertyName("connectionGroups")]
    public List<Contact>? ConnectionGroups { get; set; }

    [JsonPropertyName("elementTechnology")]
    public SolidElementTechnology? ElementTechnology { get; set; }

    [JsonPropertyName("model")]
    public SolidModel? Model { get; set; }

    [JsonPropertyName("materials")]
    public List<SolidMaterial>? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public SolidInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_HeatTransferBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("numerics")]
    public SolidNumerics? Numerics { get; set; }

    [JsonPropertyName("simulationControl")]
    public SolidSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("resultControl")]
    public SolidResultControl? ResultControl { get; set; }

    [JsonPropertyName("meshOrder")]
    public string? MeshOrder { get; set; }

}
