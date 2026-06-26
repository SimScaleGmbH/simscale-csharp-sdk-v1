using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class StringToRealValueConversion
{
    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("stringValue")]
    public JsonElement? StringValue { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
