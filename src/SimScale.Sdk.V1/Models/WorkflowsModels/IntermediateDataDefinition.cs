using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class IntermediateDataDefinition : AbstractDataDefinition
{
    [JsonPropertyName("dataTypeReference")]
    public string? DataTypeReference { get; set; }

    [JsonPropertyName("data_definition_type")]
    [JsonRequired]
    public required string DataDefinitionType { get; set; }

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

}
