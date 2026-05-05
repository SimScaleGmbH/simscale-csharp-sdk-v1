using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Incompressible : Analysis
{
    /// <summary>Schema name: Incompressible</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INCOMPRESSIBLE";

    /// <summary>Choose a turbulence model for your CFD analysis:No turbulence: LaminarRANS: k-epsilon, Realizable k-epsilon, k-omega...</summary>
    [JsonPropertyName("turbulenceModel")]
    public string? TurbulenceModel { get; set; }

    [JsonPropertyName("adjointTurbulenceModel")]
    public string? AdjointTurbulenceModel { get; set; }

    [JsonPropertyName("timeDependency")]
    public OneOf_IncompressibleTimeDependency? TimeDependency { get; set; }

    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Select the number of passive species involved in the simulation. Passive species allow you to simulate the transport...</summary>
    [JsonPropertyName("numOfPassiveSpecies")]
    public long? NumOfPassiveSpecies { get; set; }

    [JsonPropertyName("enableAdjointOptimization")]
    public bool? EnableAdjointOptimization { get; set; }

    [JsonPropertyName("model")]
    public FluidModel? Model { get; set; }

    [JsonPropertyName("materials")]
    public IncompressibleFluidMaterials? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public FluidInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_IncompressibleBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("advancedConcepts")]
    public AdvancedConcepts? AdvancedConcepts { get; set; }

    [JsonPropertyName("numerics")]
    public FluidNumerics? Numerics { get; set; }

    [JsonPropertyName("simulationControl")]
    public FluidSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("resultControl")]
    public FluidResultControls? ResultControl { get; set; }

}
