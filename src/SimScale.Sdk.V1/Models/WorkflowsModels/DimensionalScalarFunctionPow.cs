using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class DimensionalScalarFunctionPow : DimensionalScalarValue
{
    /// <summary>Value model for a dimensional scalar. Resolves to an object node with field `value` (double node) and field `unit` (t...</summary>
    [JsonPropertyName("argument1")]
    public JsonElement? Argument1 { get; set; }

    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("argument2")]
    public JsonElement? Argument2 { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
