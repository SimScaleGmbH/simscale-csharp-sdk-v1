using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class EntityAssignmentToStringValueConversion
{
    /// <summary>Value model for an entity assignment. Resolves to an object node following the [EntityAssignment] data model.</summary>
    [JsonPropertyName("entityAssignmentValue")]
    public JsonElement? EntityAssignmentValue { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
