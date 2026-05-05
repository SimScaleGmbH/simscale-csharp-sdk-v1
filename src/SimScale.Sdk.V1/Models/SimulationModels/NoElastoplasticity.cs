using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoElastoplasticity : OneOf_ElastoplasticNetworkPlasticityModelElastoplasticNetwork
{
    /// <summary>Schema name: NoElastoplasticity</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OFF";

}
