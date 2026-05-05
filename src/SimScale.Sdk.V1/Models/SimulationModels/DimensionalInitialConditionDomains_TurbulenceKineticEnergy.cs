using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalInitialConditionDomains_TurbulenceKineticEnergy
{
    [JsonPropertyName("global")]
    public Dimensional_TurbulenceKineticEnergy? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainDimensionalInitialCondition_TurbulenceKineticEnergy>? Subdomains { get; set; }

}
