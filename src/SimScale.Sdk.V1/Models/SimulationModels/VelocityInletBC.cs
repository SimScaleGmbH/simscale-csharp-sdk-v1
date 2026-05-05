using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition imposes a known velocity-based constraint at an inlet.</summary>
public class VelocityInletBC : OneOf_ConjugateHeatTransferBoundaryConditions, OneOf_CoupledConjugateHeatTransferBoundaryConditions, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_SimericsAnalysisBoundaryConditions, OneOf_MultiphaseBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_FlowDomainBoundariesXMIN, OneOf_FlowDomainBoundariesXMAX, OneOf_FlowDomainBoundariesYMIN, OneOf_FlowDomainBoundariesYMAX, OneOf_FlowDomainBoundariesZMIN, OneOf_FlowDomainBoundariesZMAX, OneOf_IncompressibleBoundaryConditions, OneOf_EmbeddedBoundaryBoundaryConditions
{
    /// <summary>This boundary condition imposes a known velocity-based constraint at an inlet. Schema name: VelocityInletBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VELOCITY_INLET_V3";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("velocity")]
    public OneOf_VelocityInletBCVelocity? Velocity { get; set; }

    [JsonPropertyName("turbulence")]
    public OneOf_VelocityInletBCTurbulence? Turbulence { get; set; }

    [JsonPropertyName("temperature")]
    public OneOf_VelocityInletBCTemperature? Temperature { get; set; }

    /// <summary>Please choose a boundary condition for passive scalar (T).</summary>
    [JsonPropertyName("passiveScalars")]
    public List<FixedValuePSBC>? PassiveScalars { get; set; }

    [JsonPropertyName("phaseFraction")]
    public FixedValuePFBC? PhaseFraction { get; set; }

    [JsonPropertyName("phaseFractionsV2")]
    public InletFixedPFValues? PhaseFractionsV2 { get; set; }

    [JsonPropertyName("massFractionsV2")]
    public InletFixedMFValues? MassFractionsV2 { get; set; }

    [JsonPropertyName("turbulenceIntensity")]
    public OneOf_VelocityInletBCTurbulenceIntensity? TurbulenceIntensity { get; set; }

    [JsonPropertyName("dissipationType")]
    public OneOf_VelocityInletBCDissipationType? DissipationType { get; set; }

    [JsonPropertyName("netRadiativeHeatFlux")]
    public OneOf_VelocityInletBCNetRadiativeHeatFlux? NetRadiativeHeatFlux { get; set; }

    [JsonPropertyName("radiativeIntensityRay")]
    public OneOf_VelocityInletBCRadiativeIntensityRay? RadiativeIntensityRay { get; set; }

    [JsonPropertyName("relativeHumidity")]
    public FixedValueRHBC? RelativeHumidity { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
