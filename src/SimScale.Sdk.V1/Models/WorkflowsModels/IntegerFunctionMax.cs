using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class IntegerFunctionMax
{
    [JsonPropertyName("argument1")]
    public IntegerValue? Argument1 { get; set; }

    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("argument2")]
    public JsonElement? Argument2 { get; set; }

}
