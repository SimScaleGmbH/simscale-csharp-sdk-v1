using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a remote force boundary condition where the load is applied on the assignment via a remote point. Therefore the assignment is connected to the remote point with RBE3 (deformable) or MPC (undeformable) conditions and the defined force is applied to the remote point.Important remarks: The total force will be distributed on the selection.As the assignments are connected to the remote point, additional constraints on these nodes may lead to overconstrained systems.If the number of nodes of the assignment is large (&gt;1000), it is recommended to use the MUMPS or PETSC solver.This boundary condition is only valid for small rotations. Learn more.</summary>
public class RemoteForceLoadBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>This is a remote force boundary condition where the load is applied on the assignment via a remote point. Therefore t...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REMOTE_FORCE_LOAD";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("force")]
    public DimensionalVectorFunction_Force? Force { get; set; }

    [JsonPropertyName("moment")]
    public DimensionalVectorFunction_Torque? Moment { get; set; }

    [JsonPropertyName("scaling")]
    public DimensionalFunction_Dimensionless? Scaling { get; set; }

    [JsonPropertyName("phaseAngle")]
    public Dimensional_Angle? PhaseAngle { get; set; }

    [JsonPropertyName("remotePoint")]
    public DimensionalVector_Length? RemotePoint { get; set; }

    /// <summary>Choose the deformation behavior of the assigned entity. If deformable is selected, the entitiy is allowed to deform w...</summary>
    [JsonPropertyName("deformationBehavior")]
    public string? DeformationBehavior { get; set; }

    [JsonPropertyName("enableSearchRadius")]
    public bool? EnableSearchRadius { get; set; }

    [JsonPropertyName("searchRadius")]
    public Dimensional_Length? SearchRadius { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
