using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>An interval with the estimated duration for a simulation run or a mesh operation.</summary>
public class Duration
{
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("intervalMin")]
    public string? IntervalMin { get; set; }

    [JsonPropertyName("intervalMax")]
    public string? IntervalMax { get; set; }

}
