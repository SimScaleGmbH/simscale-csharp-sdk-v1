using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticDomainDecomposition : OneOf_ComputingCoreDomainDecomposition
{
    /// <summary>Schema name: AutomaticDomainDecomposition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC";

}
