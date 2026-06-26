using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class IntegerToStringValueConversion
{
    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("integerValue")]
    public JsonElement? IntegerValue { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
