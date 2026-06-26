using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition should be used on two faces of a system as if they are physically connected. It is required that the two faces are of same size and shape and the face elements of the mesh are congruent on both sides. Works for uploaded meshes only. Learn more.</summary>
public class PeriodicBC : OneOf_CoupledConjugateHeatTransferBoundaryConditions, OneOf_MultiphaseBoundaryConditions, OneOf_IncompressibleBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_FlowDomainBoundariesXMIN, OneOf_FlowDomainBoundariesXMAX, OneOf_FlowDomainBoundariesYMIN, OneOf_FlowDomainBoundariesYMAX, OneOf_FlowDomainBoundariesZMIN, OneOf_FlowDomainBoundariesZMAX, OneOf_ConvectiveHeatTransferBoundaryConditions
{
    /// <summary>This boundary condition should be used on two faces of a system as if they are physically connected. It is required t...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PERIODIC";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
