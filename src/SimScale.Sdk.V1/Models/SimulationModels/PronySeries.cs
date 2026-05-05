using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PronySeries : OneOf_ViscoelasticNetworkCreepModelViscoelasticNetwork
{
    /// <summary>Schema name: PronySeries</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRONY_SERIES";

    [JsonPropertyName("pronyFactors")]
    public DimensionalFunction_Dimensionless? PronyFactors { get; set; }

}
