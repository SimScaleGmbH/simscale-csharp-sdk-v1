using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class PolymorphicCompoundTypeCheck
{
    /// <summary>Value model for a concrete compound value. Resolves to an object JSON node. Note that the serialized representation o...</summary>
    [JsonPropertyName("compoundValue")]
    public JsonElement? CompoundValue { get; set; }

    /// <summary>Value model for a string value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("targetTypeValue")]
    public JsonElement? TargetTypeValue { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
