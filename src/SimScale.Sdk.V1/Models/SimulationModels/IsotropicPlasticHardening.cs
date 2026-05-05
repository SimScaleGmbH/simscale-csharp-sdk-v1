using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the plastic hardening type of the material.</summary>
public class IsotropicPlasticHardening
{
    /// <summary>Define the plastic hardening type of the material. Schema name: IsotropicPlasticHardening</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC";

    [JsonPropertyName("youngsModulus")]
    public DimensionalFunction_Pressure? YoungsModulus { get; set; }

    [JsonPropertyName("poissonsRatio")]
    public OneOf_IsotropicPlasticHardeningPoissonsRatio? PoissonsRatio { get; set; }

    [JsonPropertyName("vonMisesStress")]
    public DimensionalFunction_Pressure? VonMisesStress { get; set; }

}
