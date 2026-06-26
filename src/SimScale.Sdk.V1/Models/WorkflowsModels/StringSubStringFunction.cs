using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class StringSubStringFunction
{
    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("from")]
    public JsonElement? From { get; set; }

    [JsonPropertyName("string")]
    public StringValue? @String { get; set; }

    /// <summary>Value model for a 64-bit signed integer value. Resolves to a long JSON node.</summary>
    [JsonPropertyName("to")]
    public JsonElement? To { get; set; }

}
