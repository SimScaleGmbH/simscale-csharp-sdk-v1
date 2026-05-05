using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a pressure boundary condition representing a distributed load on the selection. It is applied normal to the surface of all face elements.Important remarks: The applied total force depends on the surface area of the selection.The normal direction of the faces is computed only in the undeformed state and not updated for large deformations.For transient analyses you may define a time dependent value by uploading a table (csv-file).Learn more.</summary>
public class PressureBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>This is a pressure boundary condition representing a distributed load on the selection. It is applied normal to the s...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pressure")]
    public DimensionalFunction_Pressure? Pressure { get; set; }

    [JsonPropertyName("phaseAngle")]
    public Dimensional_Angle? PhaseAngle { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
