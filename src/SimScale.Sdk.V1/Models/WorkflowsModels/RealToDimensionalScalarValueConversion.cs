using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class RealToDimensionalScalarValueConversion : DimensionalScalarValue
{
    /// <summary>Value model for a 64-bit double precision floating point number. Resolves to a double JSON node.</summary>
    [JsonPropertyName("realValue")]
    public JsonElement? RealValue { get; set; }

    /// <summary>Value model for a measurement unit value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("unit")]
    public JsonElement? Unit { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
