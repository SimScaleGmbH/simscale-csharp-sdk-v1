using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition is suitable for an open boundary where the air can enter or exit freely from or to the atmosphere. Learn more.</summary>
public class NaturalConvectionInletOutletBC : OneOf_ConjugateHeatTransferBoundaryConditions, OneOf_CoupledConjugateHeatTransferBoundaryConditions, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_EmbeddedBoundaryExternalFlowBoundaryCondition, OneOf_EmbeddedBoundaryBoundaryConditions
{
    /// <summary>This boundary condition is suitable for an open boundary where the air can enter or exit freely from or to the atmosp...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NATURAL_CONVECTION_INLET_OUTLET";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pressureRgh")]
    public OneOf_NaturalConvectionInletOutletBCPressureRgh? PressureRgh { get; set; }

    [JsonPropertyName("gaugePressureRgh")]
    public AmbientPBC? GaugePressureRgh { get; set; }

    [JsonPropertyName("turbulence")]
    public OneOf_NaturalConvectionInletOutletBCTurbulence? Turbulence { get; set; }

    [JsonPropertyName("temperature")]
    public AmbientTBC? Temperature { get; set; }

    /// <summary>Please choose a boundary condition for passive scalar (T).</summary>
    [JsonPropertyName("passiveScalars")]
    public List<InletOutletPSBC>? PassiveScalars { get; set; }

    [JsonPropertyName("netRadiativeHeatFlux")]
    public OneOf_NaturalConvectionInletOutletBCNetRadiativeHeatFlux? NetRadiativeHeatFlux { get; set; }

    [JsonPropertyName("radiativeIntensityRay")]
    public OpenBoundaryRayBC? RadiativeIntensityRay { get; set; }

    [JsonPropertyName("relativeHumidity")]
    public InletOutletRHBC? RelativeHumidity { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
