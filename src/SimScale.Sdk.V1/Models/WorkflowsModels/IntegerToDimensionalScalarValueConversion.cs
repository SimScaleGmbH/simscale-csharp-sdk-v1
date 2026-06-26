using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class IntegerToDimensionalScalarValueConversion : DimensionalScalarValue
{
    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("integerValue")]
    public JsonElement? IntegerValue { get; set; }

    /// <summary>Value model for a measurement unit value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("unit")]
    public JsonElement? Unit { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
