using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class BooleanExpressionSelect
{
    [JsonPropertyName("options")]
    public List<PairBooleanValueBooleanValue>? Options { get; set; }

}
