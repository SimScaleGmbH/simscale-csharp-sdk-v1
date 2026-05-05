using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalVectorInitialConditionDomains_Speed
{
    [JsonPropertyName("global")]
    public DimensionalVector_Speed? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainDimensionalVectorInitialCondition_Speed>? Subdomains { get; set; }

}
