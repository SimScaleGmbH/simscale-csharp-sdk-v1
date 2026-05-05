using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValuePhaseFractionBC
{
    [JsonPropertyName("associatedPhase")]
    public string? AssociatedPhase { get; set; }

    [JsonPropertyName("fractionValue")]
    public double? FractionValue { get; set; }

}
