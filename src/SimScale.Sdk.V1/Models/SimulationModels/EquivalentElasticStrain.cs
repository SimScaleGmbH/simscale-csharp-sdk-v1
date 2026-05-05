using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class EquivalentElasticStrain : OneOf_MarcStrainResultControlItemStrainType
{
    /// <summary>Schema name: EquivalentElasticStrain</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "EQUIVALENT_ELASTIC";

}
