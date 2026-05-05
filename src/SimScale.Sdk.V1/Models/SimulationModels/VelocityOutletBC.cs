using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition imposes a known velocity-based constraint at an outlet.</summary>
public class VelocityOutletBC : OneOf_ConjugateHeatTransferBoundaryConditions, OneOf_CoupledConjugateHeatTransferBoundaryConditions, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_SimericsAnalysisBoundaryConditions, OneOf_MultiphaseBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_IncompressibleBoundaryConditions, OneOf_EmbeddedBoundaryBoundaryConditions
{
    /// <summary>This boundary condition imposes a known velocity-based constraint at an outlet. Schema name: VelocityOutletBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VELOCITY_OUTLET_V7";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("velocity")]
    public OneOf_VelocityOutletBCVelocity? Velocity { get; set; }

    [JsonPropertyName("phaseFraction")]
    public OneOf_VelocityOutletBCPhaseFraction? PhaseFraction { get; set; }

    [JsonPropertyName("phaseFractionsV2")]
    public OneOf_VelocityOutletBCPhaseFractionsV2? PhaseFractionsV2 { get; set; }

    [JsonPropertyName("massFractionsV2")]
    public OutletBackFlowMFValues? MassFractionsV2 { get; set; }

    [JsonPropertyName("netRadiativeHeatFlux")]
    public OneOf_VelocityOutletBCNetRadiativeHeatFlux? NetRadiativeHeatFlux { get; set; }

    [JsonPropertyName("radiativeIntensityRay")]
    public OneOf_VelocityOutletBCRadiativeIntensityRay? RadiativeIntensityRay { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
