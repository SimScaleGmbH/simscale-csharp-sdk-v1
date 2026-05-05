using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>In contrast to ordinary pressure, the follower pressure boundary condition is applied normal to the surface of all face elements in the deformed state. This is a nonlinear boundary condition as the update of the geometry is required. In a linear analysis it becomes a simple pressure boundary condition.The following conditions are taken into account: The current deformed state of the surface.Any changes in the direction of the normals of assigned entities.Changes in the surface area of the assigned faces.Learn more.</summary>
public class FollowerPressureBC : OneOf_ThermalMechanicalBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>In contrast to ordinary pressure, the follower pressure boundary condition is applied normal to the surface of all fa...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FOLLOWER_PRESSURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pressure")]
    public DimensionalFunction_Pressure? Pressure { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
