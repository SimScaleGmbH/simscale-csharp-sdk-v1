using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class EntityAssignmentToMarkdownLinkValueConversion
{
    /// <summary>Value model for an entity assignment. Resolves to an object node following the [EntityAssignment] data model.</summary>
    [JsonPropertyName("entityAssignmentValue")]
    public JsonElement? EntityAssignmentValue { get; set; }

    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("labelValue")]
    public JsonElement? LabelValue { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
