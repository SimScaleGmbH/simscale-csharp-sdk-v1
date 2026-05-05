using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicSpecificHeatMethod
{
    /// <summary>Schema name: IsotropicSpecificHeatMethod</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC_SPECIFIC_HEAT_METHOD";

    [JsonPropertyName("specificHeat")]
    public DimensionalFunction_SpecificHeat? SpecificHeat { get; set; }

}
