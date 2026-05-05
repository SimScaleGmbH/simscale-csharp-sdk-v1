using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FractionValuesInitialConditions
{
    [JsonPropertyName("global")]
    public List<FractionValueInitialCondition>? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainFractionValueInitialCondition>? Subdomains { get; set; }

}
