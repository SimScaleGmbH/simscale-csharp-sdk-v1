using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class BooleanConstant
{
    [JsonPropertyName("value")]
    public bool? Value { get; set; }

}
