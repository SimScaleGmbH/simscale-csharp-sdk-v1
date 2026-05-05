using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElementGroupsDomainDecomposition : OneOf_ComputingCoreDomainDecomposition
{
    /// <summary>Schema name: ElementGroupsDomainDecomposition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELEMENT_GROUPS";

    [JsonPropertyName("maxElementGroupSize")]
    public int? MaxElementGroupSize { get; set; }

}
