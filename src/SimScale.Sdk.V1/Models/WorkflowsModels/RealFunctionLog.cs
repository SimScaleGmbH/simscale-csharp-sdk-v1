using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class RealFunctionLog
{
    [JsonPropertyName("argument1")]
    public RealValue? Argument1 { get; set; }

    /// <summary>Value model for a 64-bit double precision floating point number. Resolves to a double JSON node.</summary>
    [JsonPropertyName("argument2")]
    public JsonElement? Argument2 { get; set; }

}
