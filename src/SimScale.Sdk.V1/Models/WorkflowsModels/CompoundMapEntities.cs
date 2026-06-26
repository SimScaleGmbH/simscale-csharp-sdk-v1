using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class CompoundMapEntities
{
    /// <summary>Value model for a concrete compound value. Resolves to an object JSON node. Note that the serialized representation o...</summary>
    [JsonPropertyName("compoundValue")]
    public JsonElement? CompoundValue { get; set; }

    [JsonPropertyName("targetAssignmentSource")]
    public EntityAssignmentSource? TargetAssignmentSource { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
