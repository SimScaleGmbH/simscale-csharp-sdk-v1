using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalInitialConditionDomains_SpecificTurbulenceDissipationRate
{
    [JsonPropertyName("global")]
    public Dimensional_SpecificTurbulenceDissipationRate? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainDimensionalInitialCondition_SpecificTurbulenceDissipationRate>? Subdomains { get; set; }

}
