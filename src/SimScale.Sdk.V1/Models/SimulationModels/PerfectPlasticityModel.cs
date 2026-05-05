using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PerfectPlasticityModel : OneOf_BilinearElastoPlasticModelHardeningModel
{
    /// <summary>Schema name: PerfectPlasticityModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PERFECT_PLASTICITY";

    [JsonPropertyName("yieldStress")]
    public DimensionalFunction_Pressure? YieldStress { get; set; }

}
