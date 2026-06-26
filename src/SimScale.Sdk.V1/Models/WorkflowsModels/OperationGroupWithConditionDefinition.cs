using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class OperationGroupWithConditionDefinition
{
    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, Dictionary<string, JsonElement>>? Metadata { get; set; }

    [JsonPropertyName("multiLanguageDoc")]
    public Dictionary<string, string>? MultiLanguageDoc { get; set; }

    [JsonPropertyName("multiLanguageLabel")]
    public Dictionary<string, string>? MultiLanguageLabel { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operation_definition_type")]
    [JsonRequired]
    public required string OperationDefinitionType { get; set; }

    [JsonPropertyName("breakpoints")]
    public List<Breakpoint>? Breakpoints { get; set; }

    /// <summary>Value model of a boolean value. Resolves to a JSON boolean or null node.</summary>
    [JsonPropertyName("condition")]
    public JsonElement? Condition { get; set; }

}
