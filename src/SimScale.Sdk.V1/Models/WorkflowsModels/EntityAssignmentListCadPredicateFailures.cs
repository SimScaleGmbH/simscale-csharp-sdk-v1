using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class EntityAssignmentListCadPredicateFailures : EntityAssignmentListValue
{
    /// <summary>Value model for an entity assignment list. Resolves to an object node following the [EntityAssignmentList] data model.</summary>
    [JsonPropertyName("assignments")]
    public JsonElement? Assignments { get; set; }

    /// <summary>A per-entity geometric predicate about a CAD model, answered by the CAD services.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
