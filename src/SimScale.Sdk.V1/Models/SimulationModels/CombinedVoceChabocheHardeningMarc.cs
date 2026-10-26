using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CombinedVoceChabocheHardeningMarc : OneOf_VoceChabocheModelMarcHardeningRule
{
    /// <summary>Schema name: CombinedVoceChabocheHardeningMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "COMBINED";

    [JsonPropertyName("asymptoticHardeningLimit")]
    public Dimensional_Pressure? AsymptoticHardeningLimit { get; set; }

    /// <summary>Controls how quickly the isotropic hardening approaches its asymptotic limit as plastic strain accumulates; higher va...</summary>
    [JsonPropertyName("isotropicSaturationRate")]
    public double? IsotropicSaturationRate { get; set; }

    [JsonPropertyName("backstressTerms")]
    public OneOf_CombinedVoceChabocheHardeningMarcBackstressTerms? BackstressTerms { get; set; }

}
