using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition is intended only for uploaded 2D OpenFOAM meshes. A 2D mesh is ensured by having a single cell thickness in one of the 3 spatial directions. Learn more.</summary>
public class Empty2DBC : OneOf_MultiphaseBoundaryConditions, OneOf_IncompressibleBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_ConjugateHeatTransferBoundaryConditions
{
    /// <summary>This boundary condition is intended only for uploaded 2D OpenFOAM meshes. A 2D mesh is ensured by having a single cel...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "EMPTY_2D";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
