using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MultilinearElastoPlasticModel : OneOf_PlasticMaterialBehaviorElastoPlasticModel
{
    /// <summary>Schema name: MultilinearElastoPlasticModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MULTILINEAR";

    [JsonPropertyName("plasticHardening")]
    public IsotropicPlasticHardening? PlasticHardening { get; set; }

}
