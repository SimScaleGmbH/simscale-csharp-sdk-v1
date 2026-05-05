using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose the material behavior for your problem. Important remarks: Choose Linear elastic if the stress-strain relationship of your material is linear.Choose Elasto-plastic if the stress-strain relationship of your material is non-linear after some point e.g. yielding point.Choose Hyperelastic if your material responds elastically even at higher deformations.</summary>
public class LinearElasticMaterialBehavior : OneOf_SolidMaterialMaterialBehavior
{
    /// <summary>Choose the material behavior for your problem. Important remarks: Choose Linear elastic if the stress-strain relation...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LINEAR_ELASTIC";

    [JsonPropertyName("directionalDependency")]
    public OneOf_LinearElasticMaterialBehaviorDirectionalDependency? DirectionalDependency { get; set; }

    [JsonPropertyName("damping")]
    public OneOf_LinearElasticMaterialBehaviorDamping? Damping { get; set; }

    [JsonPropertyName("creepFormulation")]
    public OneOf_LinearElasticMaterialBehaviorCreepFormulation? CreepFormulation { get; set; }

}
