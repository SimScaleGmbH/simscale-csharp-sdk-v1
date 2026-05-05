using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ParametricModels;

public class NumericalSequenceParameterValueGenerator
{
    /// <summary>Schema name: NumericalSequenceParameterValueGenerator</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NUMERICAL_SEQUENCE";

    [JsonPropertyName("start")]
    public double? Start { get; set; }

    [JsonPropertyName("end")]
    public double? End { get; set; }

    [JsonPropertyName("step")]
    public double? Step { get; set; }

    [JsonPropertyName("inclusive")]
    [JsonRequired]
    public required bool Inclusive { get; set; }

}
