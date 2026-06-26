using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class ValueListFunctionNone
{
    [JsonPropertyName("criteria")]
    public BooleanValue? Criteria { get; set; }

    /// <summary>Iterator reference for processing collections.</summary>
    [JsonPropertyName("iteratorReference")]
    public JsonElement? IteratorReference { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("valueList")]
    public JsonElement? ValueList { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
