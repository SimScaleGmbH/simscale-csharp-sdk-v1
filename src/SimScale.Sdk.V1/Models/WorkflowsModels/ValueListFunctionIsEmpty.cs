using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class ValueListFunctionIsEmpty
{
    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("valueList")]
    public JsonElement? ValueList { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
