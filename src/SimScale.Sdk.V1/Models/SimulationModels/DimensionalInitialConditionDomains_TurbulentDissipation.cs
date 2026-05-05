using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalInitialConditionDomains_TurbulentDissipation
{
    [JsonPropertyName("global")]
    public Dimensional_TurbulentDissipation? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainDimensionalInitialCondition_TurbulentDissipation>? Subdomains { get; set; }

}
