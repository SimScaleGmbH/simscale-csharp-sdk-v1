using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ViscoplasticMarcMaterialBehavior : OneOf_MarcMaterialMarcMaterialBehavior
{
    /// <summary>Schema name: ViscoplasticMarcMaterialBehavior</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VISCOPLASTIC_MARC";

    [JsonPropertyName("primaryNetwork")]
    public PrimaryNetwork? PrimaryNetwork { get; set; }

    [JsonPropertyName("viscoelasticNetwork")]
    public ViscoelasticNetwork? ViscoelasticNetwork { get; set; }

    [JsonPropertyName("elastoplasticNetwork")]
    public ElastoplasticNetwork? ElastoplasticNetwork { get; set; }

}
