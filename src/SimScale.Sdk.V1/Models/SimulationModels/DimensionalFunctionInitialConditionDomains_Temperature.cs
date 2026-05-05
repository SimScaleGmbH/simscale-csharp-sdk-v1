using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalFunctionInitialConditionDomains_Temperature
{
    [JsonPropertyName("global")]
    public DimensionalFunction_Temperature? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainDimensionalFunctionInitialCondition_Temperature>? Subdomains { get; set; }

}
