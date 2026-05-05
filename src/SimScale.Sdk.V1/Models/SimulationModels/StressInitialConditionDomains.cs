using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StressInitialConditionDomains
{
    [JsonPropertyName("global")]
    public StressTensor_Pressure? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainStressInitialCondition>? Subdomains { get; set; }

}
