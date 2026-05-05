using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>The actual compute resources (CPUh only) consumed by the mesh operation.</summary>
public class MeshOperationComputeResource
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }

}
