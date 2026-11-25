using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CartesianComponentVectorFunction : OneOf_DimensionalVectorFunctionWithLCS_ForceValue, OneOf_DimensionalVectorFunctionWithLCS_TorqueValue
{
    /// <summary>Schema name: CartesianComponentVectorFunction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CARTESIAN_COMPONENTS";

    [JsonPropertyName("x")]
    public OneOf_CartesianComponentVectorFunctionX? X { get; set; }

    [JsonPropertyName("y")]
    public OneOf_CartesianComponentVectorFunctionY? Y { get; set; }

    [JsonPropertyName("z")]
    public OneOf_CartesianComponentVectorFunctionZ? Z { get; set; }

}
