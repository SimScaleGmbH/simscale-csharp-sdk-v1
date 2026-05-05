using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PerfectPlasticityModelMarc : OneOf_BilinearModelMarcHardeningModel
{
    /// <summary>Schema name: PerfectPlasticityModelMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PERFECT_PLASTICITY";

}
