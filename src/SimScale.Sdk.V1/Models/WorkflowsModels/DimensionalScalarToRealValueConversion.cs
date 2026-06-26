using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class DimensionalScalarToRealValueConversion
{
    /// <summary>Value model for a dimensional scalar. Resolves to an object node with field `value` (double node) and field `unit` (t...</summary>
    [JsonPropertyName("dimensionalScalarValue")]
    public JsonElement? DimensionalScalarValue { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
