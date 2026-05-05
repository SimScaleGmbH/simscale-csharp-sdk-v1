using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalVectorFunctionInitialConditionWithDomains_Acceleration
{
    [JsonPropertyName("global")]
    public DimensionalVectorFunction_Acceleration? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainBasedDimensionalVectorFunctionInitialCondition_Acceleration>? Subdomains { get; set; }

}
