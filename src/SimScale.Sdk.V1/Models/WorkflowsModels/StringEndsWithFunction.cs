using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class StringEndsWithFunction
{
    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("postfix")]
    public JsonElement? Postfix { get; set; }

    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("string")]
    public JsonElement? @String { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
