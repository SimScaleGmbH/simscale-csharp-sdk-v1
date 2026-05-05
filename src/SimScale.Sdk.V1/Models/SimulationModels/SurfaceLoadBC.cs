using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a surface load boundary condition representing a distributed load on the selection. It is applied as surface traction in the global coordinate system.Important remarks: The applied total force depends on the surface area of the selectionLearn more.</summary>
public class SurfaceLoadBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>This is a surface load boundary condition representing a distributed load on the selection. It is applied as surface...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SURFACE_LOAD";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("load")]
    public DimensionalVectorFunction_Pressure? Load { get; set; }

    [JsonPropertyName("scaling")]
    public DimensionalFunction_Dimensionless? Scaling { get; set; }

    [JsonPropertyName("phaseAngle")]
    public Dimensional_Angle? PhaseAngle { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
