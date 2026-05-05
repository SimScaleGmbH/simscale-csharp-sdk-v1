using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoCreepFormulation : OneOf_LinearElasticMaterialBehaviorCreepFormulation
{
    /// <summary>Schema name: NoCreepFormulation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NO_CREEP";

}
