using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SignoriniHyperElasticModel : OneOf_HyperElasticMaterialBehaviorHyperElasticModel
{
    /// <summary>Schema name: SignoriniHyperElasticModel</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIGNORINI";

    [JsonPropertyName("c10")]
    public Dimensional_Pressure? C10 { get; set; }

    [JsonPropertyName("c01")]
    public Dimensional_Pressure? C01 { get; set; }

    [JsonPropertyName("c20")]
    public Dimensional_Pressure? C20 { get; set; }

    [JsonPropertyName("d1")]
    public Dimensional_InvPressure? D1 { get; set; }

}
