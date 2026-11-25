using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This boundary condition restrains the displacement of a face or edge relative to a specified remote point. Therefore the assignment is connected to the remote point with RBE3 (deformable) or MPC (undeformable) conditions and the defined constraints are applied to the remote point.Important remarks: As the assignments are connected to the remote point, additional constraints on these nodes may lead to overconstrained systems.If the number of nodes of the assigment is large (&gt;1000), it is recommended to use the MUMPS or PETSC solver.This boundary condition is only valid for small rotations. For large rotations, please use Rotating motion boundary conditions.Learn more.</summary>
public class RemoteDisplacementLoadBC : OneOf_DynamicAnalysisBoundaryConditions, OneOf_FrequencyAnalysisBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_HarmonicAnalysisBoundaryConditions
{
    /// <summary>This boundary condition restrains the displacement of a face or edge relative to a specified remote point. Therefore...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REMOTE_DISPLACEMENT_LOAD";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The coordinate system in which the Displacement and Rotation components are expressed. Select from the available loca...</summary>
    [JsonPropertyName("coordinateSystem")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CoordinateSystem { get; set; }

    [JsonPropertyName("displacementComponents")]
    public DimensionalPartialVectorFunctionWithLCS_Length? DisplacementComponents { get; set; }

    [JsonPropertyName("rotationComponents")]
    public DimensionalPartialVectorFunctionWithLCS_Angle? RotationComponents { get; set; }

    /// <summary>Choose the deformation behavior of the assigned entity. If deformable is selected, the entity is allowed to deform, s...</summary>
    [JsonPropertyName("deformationBehavior")]
    public string? DeformationBehavior { get; set; }

    [JsonPropertyName("enableSearchRadius")]
    public bool? EnableSearchRadius { get; set; }

    [JsonPropertyName("searchRadius")]
    public Dimensional_Length? SearchRadius { get; set; }

    /// <summary>Choose how the remote point which is imposing the displacement is defined. This will be the point along which the tra...</summary>
    [JsonPropertyName("pointPrimitiveUuid")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid PointPrimitiveUuid { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
