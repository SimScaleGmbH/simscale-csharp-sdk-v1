using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class DimensionalVectorToStringValueConversion
{
    /// <summary>Value model for a dimensional vector. Resolves to an object node with field `vector` containing Cartesian vector comp...</summary>
    [JsonPropertyName("dimensionalVectorValue")]
    public JsonElement? DimensionalVectorValue { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
