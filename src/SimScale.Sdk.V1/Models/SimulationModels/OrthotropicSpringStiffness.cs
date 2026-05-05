using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OrthotropicSpringStiffness : OneOf_ElasticSupportBCSpringStiffness
{
    /// <summary>Schema name: OrthotropicSpringStiffness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ORTHOTROPIC";

    [JsonPropertyName("stiffnessDefinition")]
    public OneOf_OrthotropicSpringStiffnessStiffnessDefinition? StiffnessDefinition { get; set; }

}
