using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class EntityAssignmentListFromComponents : EntityAssignmentListValue
{
    /// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
    [JsonPropertyName("entities")]
    public JsonElement? Entities { get; set; }

    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("source")]
    public JsonElement? Source { get; set; }

    /// <summary>Source type is either CAD (model) or mesh.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
