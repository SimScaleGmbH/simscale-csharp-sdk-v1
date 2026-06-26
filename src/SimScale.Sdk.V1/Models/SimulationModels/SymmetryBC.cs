using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition provides a symmetry condition on any face by applying a mirror effect. The fluxes and the normal components across the symmetry face are set to zero. Learn more.</summary>
public class SymmetryBC : OneOf_EmbeddedBoundaryBoundaryConditions, OneOf_SimericsAnalysisBoundaryConditions, OneOf_CoupledConjugateHeatTransferBoundaryConditions, OneOf_MultiphaseBoundaryConditions, OneOf_IncompressibleBoundaryConditions, OneOf_CompressibleBoundaryConditions, OneOf_ConvectiveHeatTransferBoundaryConditions, OneOf_ConjugateHeatTransferBoundaryConditions
{
    /// <summary>This boundary condition provides a symmetry condition on any face by applying a mirror effect. The fluxes and the nor...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SYMMETRY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
