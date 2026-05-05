using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a centrifugal force boundary condition. Each volume element of the selection is loaded with a centrifugal force which is calculated depending on its volume, the density of the assigned material, its distance from the axis of rotation and the defined rotational velocity.Learn more.</summary>
public class CentrifugalForceBC : OneOf_HarmonicAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions, OneOf_FrequencyAnalysisBoundaryConditions
{
    /// <summary>This is a centrifugal force boundary condition. Each volume element of the selection is loaded with a centrifugal for...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CENTRIFUGAL_FORCE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("rotation")]
    public AngularRotation? Rotation { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
