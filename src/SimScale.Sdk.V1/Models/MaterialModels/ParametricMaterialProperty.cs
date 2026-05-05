using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MaterialModels;

/// <summary>A material property containing a set of parametric values.</summary>
public class ParametricMaterialProperty : OneOfMaterialProperty
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
    public string ValueType { get; set; } = "parametric";

    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Parameter properties of the material</summary>
    [JsonPropertyName("parameters")]
    [JsonRequired]
    public required List<MaterialPropertyParameter> Parameters { get; set; }

    [JsonPropertyName("parametricValues")]
    public List<Dictionary<string, JsonElement>>? ParametricValues { get; set; }

}
