using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class StringLowerCaseFunction
{
    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("string")]
    public JsonElement? @String { get; set; }

}
