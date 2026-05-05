using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomDomainDecomposition : OneOf_ComputingCoreDomainDecomposition
{
    /// <summary>Schema name: CustomDomainDecomposition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM";

    [JsonPropertyName("numPartitions")]
    public int? NumPartitions { get; set; }

    [JsonPropertyName("partitioner")]
    public string? Partitioner { get; set; }

}
