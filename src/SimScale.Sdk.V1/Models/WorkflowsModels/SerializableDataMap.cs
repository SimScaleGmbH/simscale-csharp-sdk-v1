using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Data map provides the mapping of each data - according to the data interface of a method or a workflow - and each parameter value combination to the data identifiers.</summary>
public class SerializableDataMap
{
    [JsonPropertyName("dataByNameAndParameterValueCombinationId")]
    public Dictionary<string, Dictionary<string, string>>? DataByNameAndParameterValueCombinationId { get; set; }

    [JsonPropertyName("parameterValueCombinationsById")]
    public Dictionary<string, ParameterValueCombination>? ParameterValueCombinationsById { get; set; }

}
