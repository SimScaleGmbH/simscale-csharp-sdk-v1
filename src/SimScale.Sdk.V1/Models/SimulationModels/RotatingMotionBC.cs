using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The rotating motion constraint applies a predefined rigid body rotation to the assigned entities. The rotation axis, the base point, and the rotation angle needs to be specified. Each component can be defined with a formula or table input.Important remarks: If a component of the rotation axis is input via formula or table, then ensure that the length of the axis vector is always positive.If a continuous, transient rotation is required, then the rotation angle has to be given either as a formula or table value.Learn more.</summary>
public class RotatingMotionBC : OneOf_ThermalMechanicalBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>The rotating motion constraint applies a predefined rigid body rotation to the assigned entities. The rotation axis,...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ROTATING_MOTION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("rotationOrigin")]
    public DimensionalVectorFunction_Length? RotationOrigin { get; set; }

    [JsonPropertyName("rotationAxis")]
    public DimensionalVectorFunction_Length? RotationAxis { get; set; }

    [JsonPropertyName("omega")]
    public DimensionalFunction_Angle? Omega { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
