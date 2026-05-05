using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>The actual compute resources (CPUh or GPUh) consumed by the simulation run.</summary>
public class SimulationRunComputeResource
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }

}
