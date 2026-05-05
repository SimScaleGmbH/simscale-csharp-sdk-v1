using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedValueMassFractionBC
{
    [JsonPropertyName("fractionValue")]
    public double? FractionValue { get; set; }

}
