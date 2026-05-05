using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalInitialConditionDomains_Dimensionless
{
    [JsonPropertyName("global")]
    public Dimensional_Dimensionless? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainDimensionalInitialCondition_Dimensionless>? Subdomains { get; set; }

}
