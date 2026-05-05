using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ParametricModels;

public class ParameterWithValues : OneOf_Parameters
{
    /// <summary>Schema name: ParameterWithValues</summary>
    [JsonPropertyName("valueSource")]
    public string ValueSource { get; set; } = "CONFIGURATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("values")]
    public List<JsonElement>? Values { get; set; }

}
