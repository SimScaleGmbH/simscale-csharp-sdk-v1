using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class MaterialField
{
    [JsonPropertyName("allowsCustomization")]
    public bool? AllowsCustomization { get; set; }

    [JsonPropertyName("associatedDataType")]
    public string? AssociatedDataType { get; set; }

    [JsonPropertyName("defaultSubtype")]
    public bool? DefaultSubtype { get; set; }

    [JsonPropertyName("derivedValues")]
    public List<DerivedMaterialValue>? DerivedValues { get; set; }

    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    [JsonPropertyName("expert")]
    public bool? Expert { get; set; }

    [JsonPropertyName("fields")]
    public Dictionary<string, SchemaElement>? Fields { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("list")]
    public bool? List { get; set; }

    [JsonPropertyName("materialSchemaDataModelClassName")]
    public string? MaterialSchemaDataModelClassName { get; set; }

    [JsonPropertyName("materialSchemaPackage")]
    public string? MaterialSchemaPackage { get; set; }

    [JsonPropertyName("materialSchemaReference")]
    public string? MaterialSchemaReference { get; set; }

    [JsonPropertyName("materialSchemaValueModelClassName")]
    public string? MaterialSchemaValueModelClassName { get; set; }

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

    [JsonPropertyName("suitabilityRuleSet")]
    public ValidationRuleSet? SuitabilityRuleSet { get; set; }

    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    [JsonPropertyName("uiFieldIndex")]
    public int? UiFieldIndex { get; set; }

    [JsonPropertyName("schema_element_type")]
    [JsonRequired]
    public required string SchemaElementType { get; set; }

}
