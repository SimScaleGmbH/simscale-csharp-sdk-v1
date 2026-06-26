using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class PairBooleanValueBooleanValue
{
    [JsonPropertyName("first")]
    public BooleanValue? First { get; set; }

    /// <summary>Value model of a boolean value. Resolves to a JSON boolean or null node.</summary>
    [JsonPropertyName("second")]
    public JsonElement? Second { get; set; }

}
