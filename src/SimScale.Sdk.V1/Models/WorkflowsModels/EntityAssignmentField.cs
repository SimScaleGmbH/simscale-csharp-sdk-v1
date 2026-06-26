using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class EntityAssignmentField
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

    /// <summary>Entity type distinguished by its spatial dimensionality.</summary>
    [JsonPropertyName("allowedEntityType")]
    public string? AllowedEntityType { get; set; }

    [JsonPropertyName("allowedSourceTypes")]
    public List<string>? AllowedSourceTypes { get; set; }

}
