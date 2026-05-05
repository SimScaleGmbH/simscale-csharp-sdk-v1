using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The atmospheric boundary layer boundary condition implements the standard logarithmic profile for the stream-wise wind velocity component with corresponding profiles for turbulence kinetic energy and specific dissipation rate, where the ground roughness effects are taken into account.</summary>
public class AtmosphericBoundaryLayerInletBC : OneOf_FlowDomainBoundariesXMIN, OneOf_FlowDomainBoundariesXMAX, OneOf_FlowDomainBoundariesYMIN, OneOf_FlowDomainBoundariesYMAX, OneOf_FlowDomainBoundariesZMIN, OneOf_FlowDomainBoundariesZMAX
{
    /// <summary>The atmospheric boundary layer boundary condition implements the standard logarithmic profile for the stream-wise win...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ATMOSPHERIC_BOUNDARY_LAYER_INLET";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("referenceVelocity")]
    public Dimensional_Speed? ReferenceVelocity { get; set; }

    [JsonPropertyName("referenceHeight")]
    public Dimensional_Length? ReferenceHeight { get; set; }

    [JsonPropertyName("groundRoughness")]
    public Dimensional_Length? GroundRoughness { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
