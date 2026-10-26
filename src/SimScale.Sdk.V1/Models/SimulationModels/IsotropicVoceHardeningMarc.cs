using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicVoceHardeningMarc : OneOf_VoceChabocheModelMarcHardeningRule
{
    /// <summary>Schema name: IsotropicVoceHardeningMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC";

    [JsonPropertyName("asymptoticHardeningLimit")]
    public Dimensional_Pressure? AsymptoticHardeningLimit { get; set; }

    /// <summary>Controls how quickly the isotropic hardening approaches its asymptotic limit as plastic strain accumulates; higher va...</summary>
    [JsonPropertyName("isotropicSaturationRate")]
    public double? IsotropicSaturationRate { get; set; }

}
