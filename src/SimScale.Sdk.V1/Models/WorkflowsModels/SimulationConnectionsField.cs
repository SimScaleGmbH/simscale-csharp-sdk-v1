using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class SimulationConnectionsField
{
    [JsonPropertyName("cadInput")]
    public string? CadInput { get; set; }

    [JsonPropertyName("defaultSubtype")]
    public bool? DefaultSubtype { get; set; }

    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    [JsonPropertyName("expert")]
    public bool? Expert { get; set; }

    [JsonPropertyName("fields")]
    public Dictionary<string, SchemaElement>? Fields { get; set; }

    /// <summary>How detected face pairs are grouped into simulation connections.</summary>
    [JsonPropertyName("grouping")]
    public string? Grouping { get; set; }

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

    [JsonPropertyName("nonEmpty")]
    public bool? NonEmpty { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("polymorphic")]
    public bool? Polymorphic { get; set; }

    [JsonPropertyName("schemaDefinitionFieldIndex")]
    public int? SchemaDefinitionFieldIndex { get; set; }

    [JsonPropertyName("subtypes")]
    public List<JsonElement>? Subtypes { get; set; }

    /// <summary>Abstract compound field denotes a schema element which has nested schema elements.</summary>
    [JsonPropertyName("supertype")]
    public JsonElement? Supertype { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    [JsonPropertyName("uiFieldIndex")]
    public int? UiFieldIndex { get; set; }

    [JsonPropertyName("schema_element_type")]
    [JsonRequired]
    public required string SchemaElementType { get; set; }

}
