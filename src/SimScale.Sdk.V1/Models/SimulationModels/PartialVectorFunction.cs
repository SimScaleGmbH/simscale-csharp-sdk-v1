using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PartialVectorFunction
{
    [JsonPropertyName("x")]
    public OneOf_PartialVectorFunctionX? X { get; set; }

    [JsonPropertyName("y")]
    public OneOf_PartialVectorFunctionY? Y { get; set; }

    [JsonPropertyName("z")]
    public OneOf_PartialVectorFunctionZ? Z { get; set; }

}
