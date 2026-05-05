using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CoupledConjugateHeatTransfer : Analysis
{
    /// <summary>Schema name: CoupledConjugateHeatTransfer</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "COUPLED_CONJUGATE_HEAT_TRANSFER";

    /// <summary>Toggle off Compressible for small temperature variations within the domain, for example, in natural convection simula...</summary>
    [JsonPropertyName("isCompressible")]
    public bool? IsCompressible { get; set; }

    /// <summary>Heat transfer through radiation takes place in the form of electromagnetic waves and it can be calculated in the simu...</summary>
    [JsonPropertyName("enableRadiation")]
    public bool? EnableRadiation { get; set; }

    /// <summary>Choose a radiation model: Use the Discrete Ordinates model for steady-state cases with complex surfaces or semi-trans...</summary>
    [JsonPropertyName("radiationModel")]
    public string? RadiationModel { get; set; }

    /// <summary>Enables the solar load model in the simulation. Diffuse and/or directional solar load contributions are specified in...</summary>
    [JsonPropertyName("enableSolarLoad")]
    public bool? EnableSolarLoad { get; set; }

    /// <summary>Humidity model to simulate wet air. First turn on the compressible toggle to enable it. The simulation will take the...</summary>
    [JsonPropertyName("enableHumidityModel")]
    public bool? EnableHumidityModel { get; set; }

    /// <summary>Enabling Joule heating gives you the possibility to solve a coupled electric conduction and conjugate heat transfer p...</summary>
    [JsonPropertyName("enableJouleHeating")]
    public bool? EnableJouleHeating { get; set; }

    /// <summary>Choose a turbulence model for your CFD analysis:No turbulence: LaminarRANS: k-omega SST ,k-epsilon</summary>
    [JsonPropertyName("turbulenceModel")]
    public string? TurbulenceModel { get; set; }

    [JsonPropertyName("timeDependency")]
    public OneOf_CoupledConjugateHeatTransferTimeDependency? TimeDependency { get; set; }

    /// <summary>Select the number of passive species involved in the simulation. Passive species allow you to simulate the transport...</summary>
    [JsonPropertyName("numOfPassiveSpecies")]
    public long? NumOfPassiveSpecies { get; set; }

    [JsonPropertyName("connectionGroups")]
    public List<FluidInterface>? ConnectionGroups { get; set; }

    [JsonPropertyName("model")]
    public FluidModel? Model { get; set; }

    [JsonPropertyName("solarCalculator")]
    public SolarCalculator? SolarCalculator { get; set; }

    [JsonPropertyName("materials")]
    public CoupledConjugateHeatTransferMaterials? Materials { get; set; }

    [JsonPropertyName("initialConditions")]
    public FluidInitialConditions? InitialConditions { get; set; }

    [JsonPropertyName("boundaryConditions")]
    public List<OneOf_CoupledConjugateHeatTransferBoundaryConditions>? BoundaryConditions { get; set; }

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
