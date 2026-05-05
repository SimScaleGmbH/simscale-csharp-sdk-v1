using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition is suitable for inlet and open boundaries where the value of pressure is known.</summary>
public class PressureInletBC : OneOf_ConjugateHeatTransferBoundaryConditions, OneOf_CoupledConjugateHeatTransferBoundaryConditions, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_SimericsAnalysisBoundaryConditions, OneOf_MultiphaseBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_IncompressibleBoundaryConditions, OneOf_EmbeddedBoundaryBoundaryConditions
{
    /// <summary>This boundary condition is suitable for inlet and open boundaries where the value of pressure is known. Schema name:...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE_INLET_V31";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pressure")]
    public OneOf_PressureInletBCPressure? Pressure { get; set; }

    [JsonPropertyName("pressureRgh")]
    public OneOf_PressureInletBCPressureRgh? PressureRgh { get; set; }

    [JsonPropertyName("gaugePressure")]
    public OneOf_PressureInletBCGaugePressure? GaugePressure { get; set; }

    [JsonPropertyName("gaugePressureRgh")]
    public TotalPBC? GaugePressureRgh { get; set; }

    [JsonPropertyName("turbulence")]
    public OneOf_PressureInletBCTurbulence? Turbulence { get; set; }

    [JsonPropertyName("temperature")]
    public OneOf_PressureInletBCTemperature? Temperature { get; set; }

    /// <summary>Please choose a boundary condition for passive scalar (T).</summary>
    [JsonPropertyName("passiveScalars")]
    public List<FixedValuePSBC>? PassiveScalars { get; set; }

    [JsonPropertyName("phaseFraction")]
    public FixedValuePFBC? PhaseFraction { get; set; }

    [JsonPropertyName("phaseFractionsV2")]
    public InletFixedPFValues? PhaseFractionsV2 { get; set; }

    [JsonPropertyName("massFractionsV2")]
    public InletFixedMFValues? MassFractionsV2 { get; set; }

    [JsonPropertyName("hydrostaticPressure")]
    public HydrostaticPressure? HydrostaticPressure { get; set; }

    [JsonPropertyName("netRadiativeHeatFlux")]
    public OneOf_PressureInletBCNetRadiativeHeatFlux? NetRadiativeHeatFlux { get; set; }

    [JsonPropertyName("radiativeIntensityRay")]
    public OneOf_PressureInletBCRadiativeIntensityRay? RadiativeIntensityRay { get; set; }

    [JsonPropertyName("relativeHumidity")]
    public FixedValueRHBC? RelativeHumidity { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
