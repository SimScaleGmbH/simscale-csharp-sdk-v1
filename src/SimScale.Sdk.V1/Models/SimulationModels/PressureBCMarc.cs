using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a pressure boundary condition representing a distributed load on the selection. It is applied normal to the surface.Important remarks:If follower pressure is activated the normal direction and surface area of the faces is updated on every iteration, otherwise only in the undeformed state is used.Gradually ramp the pressure value via a table or formula depending on time [t], otherwise the full movement will be applied on the first iteration already and the simulation might fail to converge.The applied total force depends on the surface area of the selection.</summary>
public class PressureBCMarc : OneOf_MarcAnalysisBoundaryConditions
{
    /// <summary>This is a pressure boundary condition representing a distributed load on the selection. It is applied normal to the s...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pressure")]
    public DimensionalFunction_Pressure? Pressure { get; set; }

    /// <summary>When enabled, the direction of the pressure load is automatically updated to remain normal to the surface as it defor...</summary>
    [JsonPropertyName("isFollowerPressure")]
    public bool? IsFollowerPressure { get; set; }

    /// <summary>Turn this option on to assign this boundary condition or contact to specific load steps in your simulation. When enab...</summary>
    [JsonPropertyName("activateLoadSteps")]
    public bool? ActivateLoadSteps { get; set; }

    [JsonPropertyName("loadStepUuids")]
    public List<Guid>? LoadStepUuids { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
