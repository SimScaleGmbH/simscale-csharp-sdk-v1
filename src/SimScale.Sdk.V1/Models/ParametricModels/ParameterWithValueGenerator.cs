using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ParametricModels;

public class ParameterWithValueGenerator : OneOf_Parameters
{
    /// <summary>Schema name: ParameterWithValueGenerator</summary>
    [JsonPropertyName("valueSource")]
    public string ValueSource { get; set; } = "GENERATOR";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("valueGenerator")]
    public NumericalSequenceParameterValueGenerator? ValueGenerator { get; set; }

}
