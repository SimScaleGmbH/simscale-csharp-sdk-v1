using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class BooleanToStringValueConversion
{
    /// <summary>Value model of a boolean value. Resolves to a JSON boolean or null node.</summary>
    [JsonPropertyName("booleanValue")]
    public JsonElement? BooleanValue { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
