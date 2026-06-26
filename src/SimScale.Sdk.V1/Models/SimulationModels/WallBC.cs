using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary provides several Solid Wall conditions.The default no-slip corresponds to friction wall with no movement. The slip wall models a surface with no friction. The rotating/moving wall model wall movement by prescribing velocities. Learn more.</summary>
public class WallBC : OneOf_EmbeddedBoundaryExternalFlowBoundaryCondition, OneOf_EmbeddedBoundaryBoundaryConditions, OneOf_SimericsAnalysisBoundaryConditions, OneOf_CoupledConjugateHeatTransferBoundaryConditions, OneOf_MultiphaseBoundaryConditions, OneOf_IncompressibleBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_FlowDomainBoundariesXMIN, OneOf_FlowDomainBoundariesXMAX, OneOf_FlowDomainBoundariesYMIN, OneOf_FlowDomainBoundariesYMAX, OneOf_FlowDomainBoundariesZMIN, OneOf_FlowDomainBoundariesZMAX, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_ConjugateHeatTransferBoundaryConditions
{
    /// <summary>This boundary provides several Solid Wall conditions.The default no-slip corresponds to friction wall with no movemen...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WALL_V34";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("velocity")]
    public OneOf_WallBCVelocity? Velocity { get; set; }

    [JsonPropertyName("temperature")]
    public OneOf_WallBCTemperature? Temperature { get; set; }

    [JsonPropertyName("relativeHumidity")]
    public OneOf_WallBCRelativeHumidity? RelativeHumidity { get; set; }

    [JsonPropertyName("phaseFraction")]
    public OneOf_WallBCPhaseFraction? PhaseFraction { get; set; }

    [JsonPropertyName("netRadiativeHeatFlux")]
    public OneOf_WallBCNetRadiativeHeatFlux? NetRadiativeHeatFlux { get; set; }

    [JsonPropertyName("radiativeIntensityRay")]
    public OneOf_WallBCRadiativeIntensityRay? RadiativeIntensityRay { get; set; }

    [JsonPropertyName("electricBoundaryCondition")]
    public OneOf_WallBCElectricBoundaryCondition? ElectricBoundaryCondition { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
