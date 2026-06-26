using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class EnumToStringValueConversion
{
    /// <summary>Value model for an enum value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("enumValue")]
    public JsonElement? EnumValue { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
