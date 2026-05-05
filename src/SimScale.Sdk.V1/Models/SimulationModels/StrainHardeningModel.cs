using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StrainHardeningModel : OneOf_BilinearElastoPlasticModelHardeningModel
{
    /// <summary>Schema name: StrainHardeningModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRAIN_HARDENING";

    [JsonPropertyName("yieldStress")]
    public DimensionalFunction_Pressure? YieldStress { get; set; }

    [JsonPropertyName("ultimateStress")]
    public DimensionalFunction_Pressure? UltimateStress { get; set; }

    [JsonPropertyName("ultimateStrain")]
    public ConstantFunction? UltimateStrain { get; set; }

}
