using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SubdomainBasedDimensionalVectorFunctionInitialCondition_Acceleration
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("subdomainValue")]
    public DimensionalVectorFunction_Acceleration? SubdomainValue { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
