using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class EnumField
{
    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    [JsonPropertyName("expert")]
    public bool? Expert { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("list")]
    public bool? List { get; set; }

    [JsonPropertyName("modelFieldName")]
    public string? ModelFieldName { get; set; }

    [JsonPropertyName("multiLanguageDoc")]
    public Dictionary<string, string>? MultiLanguageDoc { get; set; }

    [JsonPropertyName("multiLanguageLabel")]
    public Dictionary<string, string>? MultiLanguageLabel { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("schemaDefinitionFieldIndex")]
    public int? SchemaDefinitionFieldIndex { get; set; }

    [JsonPropertyName("schema_element_type")]
    [JsonRequired]
    public required string SchemaElementType { get; set; }

    [JsonPropertyName("uiFieldIndex")]
    public int? UiFieldIndex { get; set; }

    [JsonPropertyName("default")]
    public string? @Default { get; set; }

    /// <summary>Type of the enum value.</summary>
    [JsonPropertyName("enumValueType")]
    public string? EnumValueType { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    [JsonPropertyName("valueDocs")]
    public Dictionary<string, EnumValueDoc>? ValueDocs { get; set; }

    [JsonPropertyName("valueLabels")]
    public Dictionary<string, EnumValueLabel>? ValueLabels { get; set; }

    [JsonPropertyName("values")]
    public List<string>? Values { get; set; }

}
