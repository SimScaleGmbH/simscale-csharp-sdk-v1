using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Multiphase : Analysis
{
    /// <summary>Schema name: Multiphase</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MULTIPHASE";

    /// <summary>With the Local time stepping option enabled, it’s possible to accelerate the simulation towards a steady-state. As a...</summary>
    [JsonPropertyName("useLocalTimeStepping")]
    public bool? UseLocalTimeStepping { get; set; }

    /// <summary>Choose a turbulence model for your CFD analysis:No turbulence: LaminarRANS: k-epsilon, Realizable k-epsilon, k-omega...</summary>
    [JsonPropertyName("turbulenceModel")]
    public string? TurbulenceModel { get; set; }

    [JsonPropertyName("model")]
    public FluidModel? Model { get; set; }

    [JsonPropertyName("materials")]
    public IncompressibleFluidMaterials? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public FluidInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_MultiphaseBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("advancedConcepts")]
    public AdvancedConcepts? AdvancedConcepts { get; set; }

    [JsonPropertyName("numerics")]
    public FluidNumerics? Numerics { get; set; }

    [JsonPropertyName("simulationControl")]
    public FluidSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("resultControl")]
    public FluidResultControls? ResultControl { get; set; }

}
