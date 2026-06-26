using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class DimensionalScalarComparisonLessThanOrEqual
{
    /// <summary>Value model for a dimensional scalar. Resolves to an object node with field `value` (double node) and field `unit` (t...</summary>
    [JsonPropertyName("operandA")]
    public JsonElement? OperandA { get; set; }

    /// <summary>Value model for a dimensional scalar. Resolves to an object node with field `value` (double node) and field `unit` (t...</summary>
    [JsonPropertyName("operandB")]
    public JsonElement? OperandB { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
