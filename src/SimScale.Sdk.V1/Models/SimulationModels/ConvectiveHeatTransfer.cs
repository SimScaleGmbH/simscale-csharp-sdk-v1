using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ConvectiveHeatTransfer : Analysis
{
    /// <summary>Schema name: ConvectiveHeatTransfer</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONVECTIVE_HEAT_TRANSFER";

    /// <summary>Toggle off Compressible for small temperature variations within the domain, for example, in natural convection simula...</summary>
    [JsonPropertyName("isCompressible")]
    public bool? IsCompressible { get; set; }

    /// <summary>Choose a turbulence model for your CFD analysis:No turbulence: LaminarRANS: k-epsilon, Realizable k-epsilon, k-omega...</summary>
    [JsonPropertyName("turbulenceModel")]
    public string? TurbulenceModel { get; set; }

    [JsonPropertyName("timeDependency")]
    public OneOf_ConvectiveHeatTransferTimeDependency? TimeDependency { get; set; }

    /// <summary>Heat transfer through radiation takes place in the form of electromagnetic waves and it can be calculated in the simu...</summary>
    [JsonPropertyName("enableRadiation")]
    public bool? EnableRadiation { get; set; }

    /// <summary>Select the number of passive species involved in the simulation. Passive species allow you to simulate the transport...</summary>
    [JsonPropertyName("numOfPassiveSpecies")]
    public long? NumOfPassiveSpecies { get; set; }

    [JsonPropertyName("model")]
    public FluidModel? Model { get; set; }

    [JsonPropertyName("materials")]
    public ConvectiveHeatTransferMaterials? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public FluidInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_ConvectiveHeatTransferBoundaryConditions>? BoundaryConditions { get; set; }

    [JsonPropertyName("advancedConcepts")]
    public AdvancedConcepts? AdvancedConcepts { get; set; }

    [JsonPropertyName("numerics")]
    public FluidNumerics? Numerics { get; set; }

    [JsonPropertyName("simulationControl")]
    public FluidSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("resultControl")]
    public FluidResultControls? ResultControl { get; set; }

}
