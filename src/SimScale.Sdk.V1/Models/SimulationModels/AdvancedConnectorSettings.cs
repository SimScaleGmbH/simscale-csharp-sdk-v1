using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvancedConnectorSettings
{
    /// <summary>Choose the deformation behavior of the assigned entity. If deformable is selected, the entity is allowed to deform wi...</summary>
    [JsonPropertyName("assignedFaceBehavior")]
    public string? AssignedFaceBehavior { get; set; }

}
