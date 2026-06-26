using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Encapsulates a default unit, additional units, and an optional default value for a dimensional quantity.</summary>
public class DimensionalProfileObjectDimension
{
    [JsonPropertyName("additionalUnits")]
    public List<string>? AdditionalUnits { get; set; }

    [JsonPropertyName("defaultUnit")]
    public string? DefaultUnit { get; set; }

    [JsonPropertyName("defaultValue")]
    public Dictionary<string, JsonElement>? DefaultValue { get; set; }

}
