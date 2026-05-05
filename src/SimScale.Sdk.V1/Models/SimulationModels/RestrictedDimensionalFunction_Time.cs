using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RestrictedDimensionalFunction_Time
{
    [JsonPropertyName("value")]
    public OneOf_RestrictedDimensionalFunction_TimeValue? Value { get; set; }

    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
