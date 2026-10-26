using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ThreeBackstressTerms : OneOf_KinematicChabocheHardeningMarcBackstressTerms, OneOf_CombinedVoceChabocheHardeningMarcBackstressTerms
{
    /// <summary>Schema name: ThreeBackstressTerms</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "THREE_TERMS";

    [JsonPropertyName("hardeningModulus1")]
    public Dimensional_Pressure? HardeningModulus1 { get; set; }

    /// <summary>The dynamic recovery rate of this backstress term, controlling how quickly it saturates with accumulated plastic stra...</summary>
    [JsonPropertyName("dynamicRecoveryRate1")]
    public double? DynamicRecoveryRate1 { get; set; }

    [JsonPropertyName("hardeningModulus2")]
    public Dimensional_Pressure? HardeningModulus2 { get; set; }

    /// <summary>The dynamic recovery rate of this backstress term, controlling how quickly it saturates with accumulated plastic stra...</summary>
    [JsonPropertyName("dynamicRecoveryRate2")]
    public double? DynamicRecoveryRate2 { get; set; }

    [JsonPropertyName("hardeningModulus3")]
    public Dimensional_Pressure? HardeningModulus3 { get; set; }

    /// <summary>The dynamic recovery rate of this backstress term, controlling how quickly it saturates with accumulated plastic stra...</summary>
    [JsonPropertyName("dynamicRecoveryRate3")]
    public double? DynamicRecoveryRate3 { get; set; }

}
