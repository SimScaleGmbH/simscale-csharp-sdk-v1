using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GlobalDampingValue : OneOf_LinearElasticMaterialBehaviorDamping
{
    /// <summary>Schema name: GlobalDampingValue</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GLOBAL_DAMPING_VALUE";

}
