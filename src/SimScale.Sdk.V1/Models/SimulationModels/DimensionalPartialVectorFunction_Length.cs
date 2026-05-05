using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalPartialVectorFunction_Length
{
    [JsonPropertyName("value")]
    public PartialVectorFunction? Value { get; set; }

    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
