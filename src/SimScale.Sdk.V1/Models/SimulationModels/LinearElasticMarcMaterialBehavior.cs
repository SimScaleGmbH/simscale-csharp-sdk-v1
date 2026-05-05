using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class LinearElasticMarcMaterialBehavior : OneOf_MarcMaterialMarcMaterialBehavior
{
    /// <summary>Schema name: LinearElasticMarcMaterialBehavior</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LINEAR_ELASTIC_MARC";

    [JsonPropertyName("youngsModulus")]
    public DimensionalFunction_Pressure? YoungsModulus { get; set; }

    [JsonPropertyName("poissonsRatio")]
    public OneOf_LinearElasticMarcMaterialBehaviorPoissonsRatio? PoissonsRatio { get; set; }

}
