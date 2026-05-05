using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DistributedOrthotropicStiffnessDefinition : OneOf_OrthotropicSpringStiffnessStiffnessDefinition
{
    /// <summary>Schema name: DistributedOrthotropicStiffnessDefinition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISTRIBUTED_ORTHOTROPIC";

    [JsonPropertyName("distributed")]
    public DimensionalVector_VolumeForce? Distributed { get; set; }

}
