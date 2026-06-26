using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class DimensionalVectorFromComponents : DimensionalVectorValue
{
    /// <summary>Value model for a measurement unit value. Resolves to a text JSON node.</summary>
    [JsonPropertyName("unit")]
    public JsonElement? Unit { get; set; }

    /// <summary>Value model for a 64-bit double precision floating point number. Resolves to a double JSON node.</summary>
    [JsonPropertyName("x")]
    public JsonElement? X { get; set; }

    /// <summary>Value model for a 64-bit double precision floating point number. Resolves to a double JSON node.</summary>
    [JsonPropertyName("y")]
    public JsonElement? Y { get; set; }

    /// <summary>Value model for a 64-bit double precision floating point number. Resolves to a double JSON node.</summary>
    [JsonPropertyName("z")]
    public JsonElement? Z { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
