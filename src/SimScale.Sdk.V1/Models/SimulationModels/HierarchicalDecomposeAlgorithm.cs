using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HierarchicalDecomposeAlgorithm : OneOf_FluidSimulationControlDecomposeAlgorithm
{
    /// <summary>Schema name: HierarchicalDecomposeAlgorithm</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HIERARCHICAL";

    /// <summary>Choose the order of domain decomposition .</summary>
    [JsonPropertyName("decompositionOrder")]
    public string? DecompositionOrder { get; set; }

    /// <summary>Delta is cell skew factor. It represents the cell skewness allowed at the decomposed domain boundaries and is general...</summary>
    [JsonPropertyName("delta")]
    public double? Delta { get; set; }

    /// <summary>Define the number of subdomains the mesh is split into in the specific direction.</summary>
    [JsonPropertyName("numSubdomainX")]
    public int? NumSubdomainX { get; set; }

    /// <summary>Define the number of subdomains the mesh is split into in the specific direction.</summary>
    [JsonPropertyName("numSubdomainY")]
    public int? NumSubdomainY { get; set; }

    /// <summary>Define the number of subdomains the mesh is split into in the specific direction.</summary>
    [JsonPropertyName("numSubdomainZ")]
    public int? NumSubdomainZ { get; set; }

}
