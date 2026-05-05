using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class BilinearModelMarc : OneOf_PlasticityMarcPlasticityModel
{
    /// <summary>Schema name: BilinearModelMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BILINEAR";

    [JsonPropertyName("yieldStress")]
    public Dimensional_Pressure? YieldStress { get; set; }

    [JsonPropertyName("hardeningModel")]
    public OneOf_BilinearModelMarcHardeningModel? HardeningModel { get; set; }

    [JsonPropertyName("hardeningRule")]
    public OneOf_BilinearModelMarcHardeningRule? HardeningRule { get; set; }

}
