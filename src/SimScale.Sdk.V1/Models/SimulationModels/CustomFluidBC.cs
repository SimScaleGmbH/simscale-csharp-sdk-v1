using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition allows the user to choose conditions for each physical variable separately. It provides full flexibility over the choice of boundary conditions to make advanced customization possible.</summary>
public class CustomFluidBC : OneOf_ConjugateHeatTransferBoundaryConditions, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_MultiphaseBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_IncompressibleBoundaryConditions
{
    /// <summary>This boundary condition allows the user to choose conditions for each physical variable separately. It provides full...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_V37";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("velocity")]
    public OneOf_CustomFluidBCVelocity? Velocity { get; set; }

    [JsonPropertyName("pressure")]
    public OneOf_CustomFluidBCPressure? Pressure { get; set; }

    [JsonPropertyName("pressureRgh")]
    public OneOf_CustomFluidBCPressureRgh? PressureRgh { get; set; }

    [JsonPropertyName("gaugePressure")]
    public OneOf_CustomFluidBCGaugePressure? GaugePressure { get; set; }

    [JsonPropertyName("gaugePressureRgh")]
    public OneOf_CustomFluidBCGaugePressureRgh? GaugePressureRgh { get; set; }

    [JsonPropertyName("temperature")]
    public OneOf_CustomFluidBCTemperature? Temperature { get; set; }

    [JsonPropertyName("turbulentKineticEnergy")]
    public OneOf_CustomFluidBCTurbulentKineticEnergy? TurbulentKineticEnergy { get; set; }

    [JsonPropertyName("omegaDissipationRate")]
    public OneOf_CustomFluidBCOmegaDissipationRate? OmegaDissipationRate { get; set; }

    [JsonPropertyName("epsilonDissipationRate")]
    public OneOf_CustomFluidBCEpsilonDissipationRate? EpsilonDissipationRate { get; set; }

    [JsonPropertyName("eddyViscosity")]
    public OneOf_CustomFluidBCEddyViscosity? EddyViscosity { get; set; }

    [JsonPropertyName("eddyViscosityCompressible")]
    public OneOf_CustomFluidBCEddyViscosityCompressible? EddyViscosityCompressible { get; set; }

    [JsonPropertyName("nuTilda")]
    public OneOf_CustomFluidBCNuTilda? NuTilda { get; set; }

    [JsonPropertyName("turbulentThermalDiffusivity")]
    public OneOf_CustomFluidBCTurbulentThermalDiffusivity? TurbulentThermalDiffusivity { get; set; }

    [JsonPropertyName("turbulentThermalDiffusivityCompressible")]
    public OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressible? TurbulentThermalDiffusivityCompressible { get; set; }

    [JsonPropertyName("turbulentDynamicViscosity")]
    public OneOf_CustomFluidBCTurbulentDynamicViscosity? TurbulentDynamicViscosity { get; set; }

    /// <summary>Please choose a boundary condition for passive scalar (T).</summary>
    [JsonPropertyName("passiveScalars")]
    public List<OneOf_CustomFluidBCPassiveScalars>? PassiveScalars { get; set; }

    [JsonPropertyName("phaseFraction")]
    public OneOf_CustomFluidBCPhaseFraction? PhaseFraction { get; set; }

    [JsonPropertyName("netRadiativeHeatFlux")]
    public OneOf_CustomFluidBCNetRadiativeHeatFlux? NetRadiativeHeatFlux { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
