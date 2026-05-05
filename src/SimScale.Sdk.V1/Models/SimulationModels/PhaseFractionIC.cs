using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PhaseFractionIC
{
    [JsonPropertyName("associatedPhase")]
    public string? AssociatedPhase { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }

}
