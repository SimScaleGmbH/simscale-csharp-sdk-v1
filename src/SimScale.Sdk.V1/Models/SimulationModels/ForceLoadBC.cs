using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a force boundary condition representing a distributed force on the selection. The total force is defined in the global coordinate system and each element of the assignment is loaded with a surface traction depending on the area of the element.Learn more.</summary>
public class ForceLoadBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>This is a force boundary condition representing a distributed force on the selection. The total force is defined in t...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FORCE_LOAD";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("force")]
    public DimensionalVectorFunction_Force? Force { get; set; }

    [JsonPropertyName("scaling")]
    public DimensionalFunction_Dimensionless? Scaling { get; set; }

    [JsonPropertyName("phaseAngle")]
    public Dimensional_Angle? PhaseAngle { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
