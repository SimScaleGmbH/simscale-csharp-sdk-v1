using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ViscoelasticNetwork
{
    [JsonPropertyName("creepModelViscoelasticNetwork")]
    public OneOf_ViscoelasticNetworkCreepModelViscoelasticNetwork? CreepModelViscoelasticNetwork { get; set; }

}
