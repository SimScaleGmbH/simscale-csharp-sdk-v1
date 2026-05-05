using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoneDamping : OneOf_LinearElasticMaterialBehaviorDamping
{
    /// <summary>Schema name: NoneDamping</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NONE";

}
