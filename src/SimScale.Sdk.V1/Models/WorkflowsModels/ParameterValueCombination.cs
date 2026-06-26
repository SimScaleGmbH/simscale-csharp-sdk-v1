using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class ParameterValueCombination
{
    [JsonPropertyName("parameterValues")]
    public Dictionary<string, JsonNode>? ParameterValues { get; set; }

}
