using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class AbstractCompoundField
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

    [JsonPropertyName("defaultSubtype")]
    public bool? DefaultSubtype { get; set; }

    [JsonPropertyName("polymorphic")]
    public bool? Polymorphic { get; set; }

    [JsonPropertyName("subtypes")]
    public List<Dictionary<string, JsonElement>>? Subtypes { get; set; }

    /// <summary>Abstract compound field denotes a schema element which has nested schema elements.</summary>
    [JsonPropertyName("supertype")]
    public JsonElement? Supertype { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

}
