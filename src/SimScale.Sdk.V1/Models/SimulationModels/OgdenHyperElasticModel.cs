using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose the hyperelastic material model that should be used. All models derive the stress-strain relation from a strain energy function defined by the material model parameters.</summary>
public class OgdenHyperElasticModel : OneOf_HyperElasticMaterialBehaviorHyperElasticModel
{
    /// <summary>Choose the hyperelastic material model that should be used. All models derive the stress-strain relation from a strai...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OGDEN";

    [JsonPropertyName("order")]
    public OneOf_OgdenHyperElasticModelOrder? Order { get; set; }

    [JsonPropertyName("d1")]
    public Dimensional_InvPressure? D1 { get; set; }

}
