using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PrimaryNetwork
{
    [JsonPropertyName("hyperelasticModelPrimaryNetwork")]
    public YeohPrimaryNetwork? HyperelasticModelPrimaryNetwork { get; set; }

    [JsonPropertyName("damageModelPrimaryNetwork")]
    public OneOf_PrimaryNetworkDamageModelPrimaryNetwork? DamageModelPrimaryNetwork { get; set; }

}
