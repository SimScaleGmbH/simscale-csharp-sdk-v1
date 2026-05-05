using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MaterialModels;

/// <summary>A material property that has a fixed (constant) value.</summary>
public class FixedMaterialProperty : OneOfMaterialProperty
{
    /// <summary>The material property name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The material property label to support internationalization. The content of this field is a i18n key. If this field i...</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The material property unit</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    [JsonPropertyName("valueType")]
    public string ValueType { get; set; } = "fixed";

    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>The property value</summary>
    [JsonPropertyName("value")]
    [JsonRequired]
    public required JsonElement Value { get; set; }

}
