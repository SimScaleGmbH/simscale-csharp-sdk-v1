using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class DataPresenceReference : ValueReference
{
    [JsonPropertyName("value_reference_type")]
    [JsonRequired]
    public required string ValueReferenceType { get; set; }

    [JsonPropertyName("dataName")]
    public string? DataName { get; set; }

}
