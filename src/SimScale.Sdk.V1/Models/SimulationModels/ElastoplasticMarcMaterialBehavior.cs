using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElastoplasticMarcMaterialBehavior : OneOf_MarcMaterialMarcMaterialBehavior
{
    /// <summary>Schema name: ElastoplasticMarcMaterialBehavior</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELASTOPLASTIC_MARC";

    [JsonPropertyName("elasticity")]
    public ElasticityMarc? Elasticity { get; set; }

    [JsonPropertyName("plasticity")]
    public PlasticityMarc? Plasticity { get; set; }

}
