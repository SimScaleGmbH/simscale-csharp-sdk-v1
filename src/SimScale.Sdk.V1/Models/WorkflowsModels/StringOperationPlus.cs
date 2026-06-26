using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class StringOperationPlus
{
    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("operandA")]
    public JsonElement? OperandA { get; set; }

    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("operandB")]
    public JsonElement? OperandB { get; set; }

}
