using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MooneyRivlinHyperElasticModel : OneOf_HyperElasticMaterialBehaviorHyperElasticModel
{
    /// <summary>Schema name: MooneyRivlinHyperElasticModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MOONEY_RIVLIN";

    [JsonPropertyName("c10")]
    public Dimensional_Pressure? C10 { get; set; }

    [JsonPropertyName("c01")]
    public Dimensional_Pressure? C01 { get; set; }

    [JsonPropertyName("d1")]
    public Dimensional_InvPressure? D1 { get; set; }

}
