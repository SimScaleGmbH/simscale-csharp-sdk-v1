using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class PairBooleanValueDimensionalVectorValue
{
    [JsonPropertyName("first")]
    public BooleanValue? First { get; set; }

    /// <summary>Value model for a dimensional vector. Resolves to an object node with field `vector` containing Cartesian vector comp...</summary>
    [JsonPropertyName("second")]
    public JsonElement? Second { get; set; }

}
