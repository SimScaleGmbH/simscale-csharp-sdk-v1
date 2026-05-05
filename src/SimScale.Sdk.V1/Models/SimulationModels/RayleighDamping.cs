using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RayleighDamping : OneOf_LinearElasticMaterialBehaviorDamping
{
    /// <summary>Schema name: RayleighDamping</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RAYLEIGH";

    [JsonPropertyName("stiffnessProportionalCoefficient")]
    public Dimensional_Time? StiffnessProportionalCoefficient { get; set; }

    [JsonPropertyName("massProportionalCoefficient")]
    public Dimensional_Frequency? MassProportionalCoefficient { get; set; }

}
