using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition allows to specify a pressure value at an outlet boundary.</summary>
public class PressureOutletBC : OneOf_ConjugateHeatTransferBoundaryConditions, OneOf_CoupledConjugateHeatTransferBoundaryConditions, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_SimericsAnalysisBoundaryConditions, OneOf_MultiphaseBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_FlowDomainBoundariesXMIN, OneOf_FlowDomainBoundariesXMAX, OneOf_FlowDomainBoundariesYMIN, OneOf_FlowDomainBoundariesYMAX, OneOf_FlowDomainBoundariesZMIN, OneOf_FlowDomainBoundariesZMAX, OneOf_IncompressibleBoundaryConditions, OneOf_EmbeddedBoundaryBoundaryConditions
{
    /// <summary>This boundary condition allows to specify a pressure value at an outlet boundary. Schema name: PressureOutletBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE_OUTLET_V30";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pressure")]
    public OneOf_PressureOutletBCPressure? Pressure { get; set; }

    [JsonPropertyName("pressureRgh")]
    public OneOf_PressureOutletBCPressureRgh? PressureRgh { get; set; }

    [JsonPropertyName("gaugePressure")]
    public OneOf_PressureOutletBCGaugePressure? GaugePressure { get; set; }

    [JsonPropertyName("phaseFractionsV2")]
    public OneOf_PressureOutletBCPhaseFractionsV2? PhaseFractionsV2 { get; set; }

    [JsonPropertyName("massFractionsV2")]
    public OutletBackFlowMFValues? MassFractionsV2 { get; set; }

    [JsonPropertyName("hydrostaticPressure")]
    public HydrostaticPressure? HydrostaticPressure { get; set; }

    [JsonPropertyName("gaugePressureRgh")]
    public OneOf_PressureOutletBCGaugePressureRgh? GaugePressureRgh { get; set; }

    [JsonPropertyName("netRadiativeHeatFlux")]
    public OneOf_PressureOutletBCNetRadiativeHeatFlux? NetRadiativeHeatFlux { get; set; }

    [JsonPropertyName("radiativeIntensityRay")]
    public OneOf_PressureOutletBCRadiativeIntensityRay? RadiativeIntensityRay { get; set; }

    [JsonPropertyName("relativeHumidity")]
    public InletOutletRHBC? RelativeHumidity { get; set; }

    [JsonPropertyName("temperature")]
    public AmbientTBC? Temperature { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
