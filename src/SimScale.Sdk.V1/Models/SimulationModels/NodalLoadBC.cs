using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a force boundary condition representing an equal point force on each node of the assignment. The total force applied on the assignment is calculated as the user defined forces times the number of nodes in the assignment.Important remarks: Currently, it only works on uploaded meshesAs the total load is depending on the number of nodes, and thus the mesh fineness, it is recommended only for loads on single nodes.In most cases point loads are unphysical and distributed loads should be used instead.</summary>
public class NodalLoadBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>This is a force boundary condition representing an equal point force on each node of the assignment. The total force...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NODAL_LOAD";

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
