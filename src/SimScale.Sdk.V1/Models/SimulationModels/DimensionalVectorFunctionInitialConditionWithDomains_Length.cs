using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalVectorFunctionInitialConditionWithDomains_Length
{
    [JsonPropertyName("global")]
    public DimensionalVectorFunction_Length? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainBasedDimensionalVectorFunctionInitialCondition_Length>? Subdomains { get; set; }

}
