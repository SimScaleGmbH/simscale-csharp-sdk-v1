using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PlasticStrain : OneOf_MarcStrainResultControlItemStrainType
{
    /// <summary>Schema name: PlasticStrain</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PLASTIC";

}
