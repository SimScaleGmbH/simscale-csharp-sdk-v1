using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class JohnsonCookElastoPlasticModel : OneOf_PlasticMaterialBehaviorElastoPlasticModel
{
    /// <summary>Schema name: JohnsonCookElastoPlasticModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "JOHNSON_COOK";

    [JsonPropertyName("youngsModulus")]
    public DimensionalFunction_Pressure? YoungsModulus { get; set; }

    [JsonPropertyName("poissonsRatio")]
    public OneOf_JohnsonCookElastoPlasticModelPoissonsRatio? PoissonsRatio { get; set; }

    [JsonPropertyName("initialYieldStress")]
    public DimensionalFunction_Pressure? InitialYieldStress { get; set; }

    [JsonPropertyName("hardeningCoefficient")]
    public DimensionalFunction_Pressure? HardeningCoefficient { get; set; }

    /// <summary>The strain hardening exponent describes the rate at which the material hardens with respect to plastic strain.</summary>
    [JsonPropertyName("hardeningExponent")]
    public double? HardeningExponent { get; set; }

    /// <summary>This term indicates how the flow stress increases with increasing strain rate.</summary>
    [JsonPropertyName("strainRateEffect")]
    public bool? StrainRateEffect { get; set; }

    /// <summary>The strain rate hardening coefficient describes the sensitivity of the material's flow stress to changes in the strai...</summary>
    [JsonPropertyName("strainRateHardeningCoefficient")]
    public double? StrainRateHardeningCoefficient { get; set; }

    [JsonPropertyName("referenceStrainRate")]
    public Dimensional_StrainRate? ReferenceStrainRate { get; set; }

    /// <summary>This term indicates how the material softens with increasing temperature.</summary>
    [JsonPropertyName("thermalSofteningEffect")]
    public bool? ThermalSofteningEffect { get; set; }

    /// <summary>The thermal softening exponent describes the rate at which the material's strength decreases with increasing temperat...</summary>
    [JsonPropertyName("thermalSofteningExponent")]
    public double? ThermalSofteningExponent { get; set; }

    [JsonPropertyName("referenceTemperatureJC")]
    public Dimensional_Temperature? ReferenceTemperatureJC { get; set; }

    [JsonPropertyName("meltingTemperatureJC")]
    public Dimensional_Temperature? MeltingTemperatureJC { get; set; }

}
