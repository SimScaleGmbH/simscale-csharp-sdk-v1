using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvancedConnectorSettings
{
    /// <summary>How the assigned faces are tied to the connector:Deformable (RBE3): the faces can deform, e.g. a hole can ovalize. Th...</summary>
    [JsonPropertyName("assignedFaceBehavior")]
    public string? AssignedFaceBehavior { get; set; }

}
