using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ThermalMechanical : Analysis
{
    /// <summary>Schema name: ThermalMechanical</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "THERMAL_MECHANICAL";

    [JsonPropertyName("timeDependency")]
    public OneOf_ThermalMechanicalTimeDependency? TimeDependency { get; set; }

    /// <summary>Select if inertia effects should be considered in the analysis. If high loading accelerations or impacts are present...</summary>
    [JsonPropertyName("inertiaEffect")]
    public string? InertiaEffect { get; set; }

    /// <summary>Choose if your analysis should feature any kind of nonlinearity like physical contacts, nonlinear materials as hypere...</summary>
    [JsonPropertyName("nonLinearAnalysis")]
    public bool? NonLinearAnalysis { get; set; }

    [JsonPropertyName("connectionGroups")]
    public List<OneOf_ThermalMechanicalConnectionGroups>? ConnectionGroups { get; set; }

    [JsonPropertyName("connectors")]
    public List<PinConnector>? Connectors { get; set; }

    [JsonPropertyName("elementTechnology")]
    public SolidElementTechnology? ElementTechnology { get; set; }

    [JsonPropertyName("model")]
    public SolidModel? Model { get; set; }

    [JsonPropertyName("materials")]
    public List<SolidMaterial>? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public SolidInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_ThermalMechanicalBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("numerics")]
    public SolidNumerics? Numerics { get; set; }

    [JsonPropertyName("simulationControl")]
    public SolidSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("resultControl")]
    public SolidResultControl? ResultControl { get; set; }

    [JsonPropertyName("meshOrder")]
    public string? MeshOrder { get; set; }

}
