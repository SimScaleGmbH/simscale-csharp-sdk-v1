using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ModerateContactStiffness : OneOf_PenaltyMethodContactStiffness
{
    /// <summary>Schema name: ModerateContactStiffness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MODERATE_CONTACT_STIFFNESS";

}
