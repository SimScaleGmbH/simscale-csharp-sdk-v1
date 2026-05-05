using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalInitialConditionDomains_Temperature
{
    [JsonPropertyName("global")]
    public Dimensional_Temperature? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainDimensionalInitialCondition_Temperature>? Subdomains { get; set; }

}
