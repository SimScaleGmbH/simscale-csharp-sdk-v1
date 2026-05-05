using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition is applied to the front and back faces of an axisymmetric system (eg. cylinder). Note that the face elements of the mesh need to be congruent on both the faces. Works for uploaded 2D meshes only. Learn more.</summary>
public class WedgeBC : OneOf_ConjugateHeatTransferBoundaryConditions, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_MultiphaseBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_IncompressibleBoundaryConditions
{
    /// <summary>This boundary condition is applied to the front and back faces of an axisymmetric system (eg. cylinder). Note that th...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WEDGE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
