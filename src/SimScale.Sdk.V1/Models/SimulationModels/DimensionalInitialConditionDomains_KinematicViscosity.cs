using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DimensionalInitialConditionDomains_KinematicViscosity
{
    [JsonPropertyName("global")]
    public Dimensional_KinematicViscosity? Global { get; set; }

    [JsonPropertyName("subdomains")]
    public List<SubdomainDimensionalInitialCondition_KinematicViscosity>? Subdomains { get; set; }

}
