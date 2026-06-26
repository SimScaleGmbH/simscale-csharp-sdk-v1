using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class IntegerOperationMinus
{
    [JsonPropertyName("operandA")]
    public IntegerValue? OperandA { get; set; }

    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("operandB")]
    public JsonElement? OperandB { get; set; }

}
