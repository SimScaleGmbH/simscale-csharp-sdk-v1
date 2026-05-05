using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PrincipalPlasticStrain : OneOf_MarcStrainResultControlItemStrainType
{
    /// <summary>Schema name: PrincipalPlasticStrain</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRINCIPAL_PLASTIC";

}
