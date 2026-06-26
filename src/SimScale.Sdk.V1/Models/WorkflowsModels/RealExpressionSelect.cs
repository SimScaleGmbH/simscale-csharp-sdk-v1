using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class RealExpressionSelect
{
    [JsonPropertyName("options")]
    public List<PairBooleanValueRealValue>? Options { get; set; }

}
