using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class BilinearElastoPlasticModel : OneOf_PlasticMaterialBehaviorElastoPlasticModel
{
    /// <summary>Schema name: BilinearElastoPlasticModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BILINEAR";

    [JsonPropertyName("youngsModulus")]
    public DimensionalFunction_Pressure? YoungsModulus { get; set; }

    [JsonPropertyName("poissonsRatio")]
    public OneOf_BilinearElastoPlasticModelPoissonsRatio? PoissonsRatio { get; set; }

    [JsonPropertyName("hardeningModel")]
    public OneOf_BilinearElastoPlasticModelHardeningModel? HardeningModel { get; set; }

}
