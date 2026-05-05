using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalVectorFunctionInitialConditionWithDomains_Speed
{
    [JsonPropertyName("global")]
    public DimensionalVectorFunction_Speed? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainBasedDimensionalVectorFunctionInitialCondition_Speed>? Subdomains { get; set; }

}
