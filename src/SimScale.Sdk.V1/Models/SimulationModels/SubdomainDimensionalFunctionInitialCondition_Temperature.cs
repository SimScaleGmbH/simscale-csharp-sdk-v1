using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SubdomainDimensionalFunctionInitialCondition_Temperature
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("subdomainValue")]
    public DimensionalFunction_Temperature? SubdomainValue { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
