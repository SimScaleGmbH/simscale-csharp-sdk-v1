using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionlessInitialConditionDomains
{
    [JsonPropertyName("subdomains")]
    public List<SubdomainDimensionlessInitialCondition>? Subdomains { get; set; }

}
