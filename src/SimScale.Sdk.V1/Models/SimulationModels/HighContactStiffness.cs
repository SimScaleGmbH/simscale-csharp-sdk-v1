using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HighContactStiffness : OneOf_PenaltyMethodContactStiffness
{
    /// <summary>Schema name: HighContactStiffness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HIGH_CONTACT_STIFFNESS";

}
