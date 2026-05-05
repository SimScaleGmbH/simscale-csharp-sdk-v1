using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomContactStiffness : OneOf_PenaltyMethodContactStiffness
{
    /// <summary>Schema name: CustomContactStiffness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_CONTACT_STIFFNESS";

    /// <summary>Define the penalty coefficient for the contact pair. As a good starting point this value should be about 5-50 times a...</summary>
    [JsonPropertyName("penaltyCoefficient")]
    public double? PenaltyCoefficient { get; set; }

}
