using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class IteratorReference : ValueReference
{
    [JsonPropertyName("value_reference_type")]
    [JsonRequired]
    public required string ValueReferenceType { get; set; }

    [JsonPropertyName("iteratorId")]
    public string? IteratorId { get; set; }

    [JsonPropertyName("valuePath")]
    public string? ValuePath { get; set; }

}
