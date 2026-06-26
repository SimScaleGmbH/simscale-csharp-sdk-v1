using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class BooleanOperationOr
{
    [JsonPropertyName("operandA")]
    public BooleanValue? OperandA { get; set; }

    /// <summary>Value model of a boolean value. Resolves to a JSON boolean or null node.</summary>
    [JsonPropertyName("operandB")]
    public JsonElement? OperandB { get; set; }

}
