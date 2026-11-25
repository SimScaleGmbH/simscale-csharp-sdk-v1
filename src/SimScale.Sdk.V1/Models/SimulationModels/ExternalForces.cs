using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ExternalForces
{
    /// <summary>Whether the weight of the body acts on the motion. Only the projection of the weight onto the motion axis has an effe...</summary>
    [JsonPropertyName("enableGravity")]
    public bool? EnableGravity { get; set; }

    [JsonPropertyName("springDamper")]
    public SpringDamper? SpringDamper { get; set; }

    [JsonPropertyName("externalForce")]
    public DimensionalFunction_Force? ExternalForce { get; set; }

}
