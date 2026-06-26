using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class PairBooleanValueRealValue
{
    [JsonPropertyName("first")]
    public BooleanValue? First { get; set; }

    /// <summary>Value model for a 64-bit double precision floating point number. Resolves to a double JSON node.</summary>
    [JsonPropertyName("second")]
    public JsonElement? Second { get; set; }

}
