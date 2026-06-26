using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class RealComparisonGreaterThan
{
    /// <summary>Value model for a 64-bit double precision floating point number. Resolves to a double JSON node.</summary>
    [JsonPropertyName("operandA")]
    public JsonElement? OperandA { get; set; }

    /// <summary>Value model for a 64-bit double precision floating point number. Resolves to a double JSON node.</summary>
    [JsonPropertyName("operandB")]
    public JsonElement? OperandB { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
