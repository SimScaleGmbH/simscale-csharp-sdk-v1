using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class PairBooleanValueDimensionalScalarValue
{
    [JsonPropertyName("first")]
    public BooleanValue? First { get; set; }

    /// <summary>Value model for a dimensional scalar. Resolves to an object node with field `value` (double node) and field `unit` (t...</summary>
    [JsonPropertyName("second")]
    public JsonElement? Second { get; set; }

}
