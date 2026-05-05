using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TimeDifferentiationSchemes
{
    [JsonPropertyName("forDefault")]
    public OneOf_TimeDifferentiationSchemesForDefault? ForDefault { get; set; }

    [JsonPropertyName("secondOrderScheme")]
    public bool? SecondOrderScheme { get; set; }

}
