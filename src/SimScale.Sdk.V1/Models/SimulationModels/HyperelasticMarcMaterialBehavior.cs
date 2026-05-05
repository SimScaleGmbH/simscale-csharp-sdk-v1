using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HyperelasticMarcMaterialBehavior : OneOf_MarcMaterialMarcMaterialBehavior
{
    /// <summary>Schema name: HyperelasticMarcMaterialBehavior</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HYPERELASTIC_MARC";

    [JsonPropertyName("hyperelasticity")]
    public Hyperelasticity? Hyperelasticity { get; set; }

}
