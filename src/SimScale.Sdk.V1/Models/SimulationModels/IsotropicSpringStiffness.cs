using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IsotropicSpringStiffness : OneOf_ElasticSupportBCSpringStiffness
{
    /// <summary>Schema name: IsotropicSpringStiffness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ISOTROPIC";

    [JsonPropertyName("stiffnessDefinition")]
    public OneOf_IsotropicSpringStiffnessStiffnessDefinition? StiffnessDefinition { get; set; }

}
