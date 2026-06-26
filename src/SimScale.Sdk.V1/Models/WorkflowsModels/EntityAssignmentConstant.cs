using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class EntityAssignmentConstant : EntityAssignmentValue
{
    [JsonPropertyName("entityAssignment")]
    public EntityAssignment? EntityAssignment { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
