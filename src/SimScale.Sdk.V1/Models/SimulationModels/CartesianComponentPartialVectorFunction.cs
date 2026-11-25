using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CartesianComponentPartialVectorFunction : OneOf_DimensionalPartialVectorFunctionWithLCS_AngleValue, OneOf_DimensionalPartialVectorFunctionWithLCS_LengthValue
{
    /// <summary>Schema name: CartesianComponentPartialVectorFunction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CARTESIAN_COMPONENTS";

    [JsonPropertyName("x")]
    public OneOf_CartesianComponentPartialVectorFunctionX? X { get; set; }

    [JsonPropertyName("y")]
    public OneOf_CartesianComponentPartialVectorFunctionY? Y { get; set; }

    [JsonPropertyName("z")]
    public OneOf_CartesianComponentPartialVectorFunctionZ? Z { get; set; }

}
