using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class MethodOperationDefinition : AtomicOperationDefinition
{
    [JsonPropertyName("configurationDataSources")]
    public List<DataReference>? ConfigurationDataSources { get; set; }

    /// <summary>Value model for a concrete compound value. Resolves to an object JSON node. Note that the serialized representation o...</summary>
    [JsonPropertyName("configurationValueModel")]
    public JsonElement? ConfigurationValueModel { get; set; }

    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    [JsonPropertyName("inputMapping")]
    public List<DataMappingEntry>? InputMapping { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, Dictionary<string, JsonElement>>? Metadata { get; set; }

    [JsonPropertyName("methodReference")]
    public string? MethodReference { get; set; }

    [JsonPropertyName("multiLanguageDoc")]
    public Dictionary<string, string>? MultiLanguageDoc { get; set; }

    [JsonPropertyName("multiLanguageLabel")]
    public Dictionary<string, string>? MultiLanguageLabel { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("outputMapping")]
    public List<DataMappingEntry>? OutputMapping { get; set; }

    [JsonPropertyName("operation_definition_type")]
    [JsonRequired]
    public required string OperationDefinitionType { get; set; }

}
