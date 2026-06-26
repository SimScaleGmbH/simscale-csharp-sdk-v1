using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition restrains the displacement of a face in its normal direction in order to represent a symmetry plane of the structure. Use this boundary condition to reduce the model size significantly if the geometry and the loading conditions are symmetric.Important remarks: The solver uses linear relations between all three DOFs to constrian the normal movement, thus overcontraint conditions may appear if the edges of the selected faces are constrained by other displacement boundary conditions.If the assigned faces are orthogonal to a global coordinate axes, it is recommended to directly specifiy the symmetry conditions with a Fixed value boundary condition.Learn more.</summary>
public class SymmetryPlaneBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_FrequencyAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>This boundary condition restrains the displacement of a face in its normal direction in order to represent a symmetry...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SYMMETRY_PLANE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
