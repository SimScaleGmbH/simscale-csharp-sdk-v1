using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a volume load boundary condition representing a distributed load on the selected volumes applied in the global coordinate system and each element of the assignment is loaded with a volume force depending on the volume of the element.Important remarks: The applied total force depends on the volume of the selection.Learn more.</summary>
public class VolumeLoadBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>This is a volume load boundary condition representing a distributed load on the selected volumes applied in the globa...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOLUME_LOAD";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("load")]
    public DimensionalVectorFunction_VolumeForce? Load { get; set; }

    [JsonPropertyName("scaling")]
    public DimensionalFunction_Dimensionless? Scaling { get; set; }

    [JsonPropertyName("phaseAngle")]
    public Dimensional_Angle? PhaseAngle { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
