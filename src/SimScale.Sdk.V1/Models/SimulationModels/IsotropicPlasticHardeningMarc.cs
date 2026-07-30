using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicPlasticHardeningMarc : OneOf_BilinearModelMarcHardeningRule, OneOf_MultilinearModelMarcHardeningRule
{
    /// <summary>Schema name: IsotropicPlasticHardeningMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC";

}
