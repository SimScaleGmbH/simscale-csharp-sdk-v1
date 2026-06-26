using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class RealToIntegerConversion
{
    /// <summary>Value model for a 64-bit double precision floating point number. Resolves to a double JSON node.</summary>
    [JsonPropertyName("argument")]
    public JsonElement? Argument { get; set; }

    /// <summary>Real value conversion to integer value strategies.</summary>
    [JsonPropertyName("realToIntegerConversionType")]
    public string? RealToIntegerConversionType { get; set; }

    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
