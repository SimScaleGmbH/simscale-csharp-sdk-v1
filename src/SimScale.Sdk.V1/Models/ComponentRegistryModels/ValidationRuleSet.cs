using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Set of validation rules. It can be associated to for example a workflow type configuration schema or a method configuration schema.</summary>
public class ValidationRuleSet
{
    [JsonPropertyName("rules")]
    public List<ValidationRule>? Rules { get; set; }

}
