using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class LowContactStiffness : OneOf_PenaltyMethodContactStiffness
{
    /// <summary>Schema name: LowContactStiffness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LOW_CONTACT_STIFFNESS";

}
