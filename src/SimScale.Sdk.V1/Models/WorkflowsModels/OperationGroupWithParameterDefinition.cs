using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class OperationGroupWithParameterDefinition
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

    /// <summary>Iterator reference for processing collections.</summary>
    [JsonPropertyName("iteratorReference")]
    public JsonElement? IteratorReference { get; set; }

    [JsonPropertyName("parameterDoc")]
    public string? ParameterDoc { get; set; }

    [JsonPropertyName("parameterLabel")]
    public string? ParameterLabel { get; set; }

    [JsonPropertyName("parameterMultiLanguageDoc")]
    public Dictionary<string, string>? ParameterMultiLanguageDoc { get; set; }

    [JsonPropertyName("parameterMultiLanguageLabel")]
    public Dictionary<string, string>? ParameterMultiLanguageLabel { get; set; }

    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("valueList")]
    public JsonElement? ValueList { get; set; }

}
