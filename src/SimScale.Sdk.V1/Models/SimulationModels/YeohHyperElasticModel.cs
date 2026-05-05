using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class YeohHyperElasticModel : OneOf_HyperElasticMaterialBehaviorHyperElasticModel
{
    /// <summary>Schema name: YeohHyperElasticModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "YEOH";

    [JsonPropertyName("c10")]
    public Dimensional_Pressure? C10 { get; set; }

    [JsonPropertyName("c20")]
    public Dimensional_Pressure? C20 { get; set; }

    [JsonPropertyName("c30")]
    public Dimensional_Pressure? C30 { get; set; }

    [JsonPropertyName("d1")]
    public Dimensional_InvPressure? D1 { get; set; }

}
