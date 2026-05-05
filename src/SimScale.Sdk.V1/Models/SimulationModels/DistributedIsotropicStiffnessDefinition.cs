using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DistributedIsotropicStiffnessDefinition : OneOf_IsotropicSpringStiffnessStiffnessDefinition
{
    /// <summary>Schema name: DistributedIsotropicStiffnessDefinition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISTRIBUTED_ISOTROPIC";

    [JsonPropertyName("distributed")]
    public Dimensional_VolumeForce? Distributed { get; set; }

}
