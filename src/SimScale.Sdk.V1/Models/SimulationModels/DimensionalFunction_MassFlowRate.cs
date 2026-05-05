using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalFunction_MassFlowRate
{
    [JsonPropertyName("value")]
    public OneOf_DimensionalFunction_MassFlowRateValue? Value { get; set; }

    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
