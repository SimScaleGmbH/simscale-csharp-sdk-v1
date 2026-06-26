using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class CompoundValue
{
    [JsonPropertyName("fields")]
    public Dictionary<string, Dictionary<string, JsonElement>>? Fields { get; set; }

    [JsonPropertyName("polymorphicCompoundValue")]
    public bool? PolymorphicCompoundValue { get; set; }

    [JsonPropertyName("subtypeId")]
    public string? SubtypeId { get; set; }

    [JsonPropertyName("subtypes")]
    public Dictionary<string, JsonElement>? Subtypes { get; set; }

    [JsonPropertyName("valueReference")]
    public ValueReference? ValueReference { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
