using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class EntityAssignmentListFunctionIsEmpty
{
    /// <summary>Value model for an entity assignment list. Resolves to an object node following the [EntityAssignmentList] data model.</summary>
    [JsonPropertyName("entityAssignmentListValue")]
    public JsonElement? EntityAssignmentListValue { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
