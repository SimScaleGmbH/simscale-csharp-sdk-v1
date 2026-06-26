using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class DimensionalScalarFromDimensionalVectorComponent : DimensionalScalarValue
{
    /// <summary>Components of a dimensional vector (x, y, z).</summary>
    [JsonPropertyName("component")]
    public string? Component { get; set; }

    /// <summary>Value model for a dimensional vector. Resolves to an object node with field `vector` containing Cartesian vector comp...</summary>
    [JsonPropertyName("vector")]
    public JsonElement? Vector { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
