using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class DataMappingEntry
{
    [JsonPropertyName("dataReference")]
    public DataReference? DataReference { get; set; }

    [JsonPropertyName("operationDataName")]
    public string? OperationDataName { get; set; }

    [JsonPropertyName("parameterNameMapping")]
    public Dictionary<string, string>? ParameterNameMapping { get; set; }

}
