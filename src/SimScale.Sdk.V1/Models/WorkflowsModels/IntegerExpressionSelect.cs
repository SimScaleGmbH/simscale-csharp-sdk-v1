using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class IntegerExpressionSelect
{
    [JsonPropertyName("options")]
    public List<PairBooleanValueIntegerValue>? Options { get; set; }

}
