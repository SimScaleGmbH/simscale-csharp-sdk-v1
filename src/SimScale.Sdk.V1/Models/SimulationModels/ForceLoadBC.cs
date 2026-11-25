using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a force boundary condition representing a distributed force on the selection. The total force is defined in the global coordinate system and each element of the assignment is loaded with a surface traction depending on the area of the element.Learn more.</summary>
public class ForceLoadBC : OneOf_DynamicAnalysisBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_HarmonicAnalysisBoundaryConditions
{
    /// <summary>This is a force boundary condition representing a distributed force on the selection. The total force is defined in t...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FORCE_LOAD";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The coordinate system in which the vector components are expressed. Select from the available local coordinate system...</summary>
    [JsonPropertyName("coordinateSystem")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CoordinateSystem { get; set; }

    [JsonPropertyName("forceComponents")]
    public DimensionalVectorFunctionWithLCS_Force? ForceComponents { get; set; }

    [JsonPropertyName("scaling")]
    public DimensionalFunction_Dimensionless? Scaling { get; set; }

    [JsonPropertyName("phaseAngle")]
    public Dimensional_Angle? PhaseAngle { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
