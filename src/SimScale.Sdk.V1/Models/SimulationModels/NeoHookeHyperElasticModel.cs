using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NeoHookeHyperElasticModel : OneOf_HyperElasticMaterialBehaviorHyperElasticModel
{
    /// <summary>Schema name: NeoHookeHyperElasticModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NEO_HOOKE";

    [JsonPropertyName("c10")]
    public Dimensional_Pressure? C10 { get; set; }

    [JsonPropertyName("d1")]
    public Dimensional_InvPressure? D1 { get; set; }

}
