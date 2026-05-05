using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HystereticDamping : OneOf_LinearElasticMaterialBehaviorDamping
{
    /// <summary>Schema name: HystereticDamping</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HYSTERETIC";

    /// <summary>Specify the level of damping to be applied as a percentage of critical damping.</summary>
    [JsonPropertyName("dampingLevel")]
    public double? DampingLevel { get; set; }

}
