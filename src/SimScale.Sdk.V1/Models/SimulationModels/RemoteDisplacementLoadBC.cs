using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition restrains the displacement of a face or edge relative to a specified remote point. Therefore the assignment is connected to the remote point with RBE3 (deformable) or MPC (undeformable) conditions and the defined constraints are applied to the remote point.Important remarks: As the assignments are connected to the remote point, additional constraints on these nodes may lead to overconstrained systems.If the number of nodes of the assigment is large (&gt;1000), it is recommended to use the MUMPS or PETSC solver.This boundary condition is only valid for small rotations. For large rotations, please use Rotating motion boundary conditions.Learn more.</summary>
public class RemoteDisplacementLoadBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions, OneOf_FrequencyAnalysisBoundaryConditions
{
    /// <summary>This boundary condition restrains the displacement of a face or edge relative to a specified remote point. Therefore...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REMOTE_DISPLACEMENT_LOAD";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("displacement")]
    public DimensionalPartialVectorFunction_Length? Displacement { get; set; }

    [JsonPropertyName("rotation")]
    public DimensionalPartialVectorFunction_Angle? Rotation { get; set; }

    [JsonPropertyName("externalPoint")]
    public DimensionalVector_Length? ExternalPoint { get; set; }

    /// <summary>Choose the deformation behavior of the assigned entity. If deformable is selected, the entity is allowed to deform, s...</summary>
    [JsonPropertyName("deformationBehavior")]
    public string? DeformationBehavior { get; set; }

    [JsonPropertyName("enableSearchRadius")]
    public bool? EnableSearchRadius { get; set; }

    [JsonPropertyName("searchRadius")]
    public Dimensional_Length? SearchRadius { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
