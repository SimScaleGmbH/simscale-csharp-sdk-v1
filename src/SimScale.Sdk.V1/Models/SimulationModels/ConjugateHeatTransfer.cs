using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ConjugateHeatTransfer : Analysis
{
    /// <summary>Schema name: ConjugateHeatTransfer</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONJUGATE_HEAT_TRANSFER";

    /// <summary>Choose a turbulence model for your CFD analysis:No turbulence: LaminarRANS: k-epsilon, Realizable k-epsilon, k-omega...</summary>
    [JsonPropertyName("turbulenceModel")]
    public string? TurbulenceModel { get; set; }

    [JsonPropertyName("timeDependency")]
    public OneOf_ConjugateHeatTransferTimeDependency? TimeDependency { get; set; }

    /// <summary>Heat transfer through radiation takes place in the form of electromagnetic waves and it can be calculated in the simu...</summary>
    [JsonPropertyName("enableRadiation")]
    public bool? EnableRadiation { get; set; }

    [JsonPropertyName("connectionGroups")]
    public List<FluidInterface>? ConnectionGroups { get; set; }

    [JsonPropertyName("model")]
    public FluidModel? Model { get; set; }

    [JsonPropertyName("materials")]
    public ConjugateHeatTransferMaterials? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public FluidInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_ConjugateHeatTransferBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("advancedConcepts")]
    public AdvancedConcepts? AdvancedConcepts { get; set; }

    [JsonPropertyName("numerics")]
    public FluidNumerics? Numerics { get; set; }

    [JsonPropertyName("simulationControl")]
    public FluidSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("resultControl")]
    public FluidResultControls? ResultControl { get; set; }

    [JsonPropertyName("contactHandlingMode")]
    public string? ContactHandlingMode { get; set; }

}
