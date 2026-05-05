using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>An interval with the estimated compute resources (CPUh or GPUh) required to run the simulation.</summary>
public class ComputeResource
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("intervalMin")]
    public double? IntervalMin { get; set; }

    [JsonPropertyName("intervalMax")]
    public double? IntervalMax { get; set; }

}
