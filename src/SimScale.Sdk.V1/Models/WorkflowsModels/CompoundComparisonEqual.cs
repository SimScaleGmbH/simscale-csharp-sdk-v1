using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class CompoundComparisonEqual
{
    /// <summary>Value model for a compound value. Resolves to an object JSON node.</summary>
    [JsonPropertyName("operandA")]
    public JsonElement? OperandA { get; set; }

    /// <summary>Value model for a compound value. Resolves to an object JSON node.</summary>
    [JsonPropertyName("operandB")]
    public JsonElement? OperandB { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
