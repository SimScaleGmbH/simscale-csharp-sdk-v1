using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class BooleanComparisonNotEqual
{
    [JsonPropertyName("operandA")]
    public BooleanValue? OperandA { get; set; }

    [JsonPropertyName("operandB")]
    public BooleanValue? OperandB { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
