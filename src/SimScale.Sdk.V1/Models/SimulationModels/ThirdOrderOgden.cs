using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ThirdOrderOgden : OneOf_OgdenHyperElasticModelOrder
{
    /// <summary>Schema name: ThirdOrderOgden</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "THIRD_ORDER_OGDEN";

    [JsonPropertyName("mu1")]
    public Dimensional_Pressure? Mu1 { get; set; }

    /// <summary>Provide a parameter value for the Ogden coefficient &amp;alpha;1.</summary>
    [JsonPropertyName("alpha1")]
    public double? Alpha1 { get; set; }

    [JsonPropertyName("mu2")]
    public Dimensional_Pressure? Mu2 { get; set; }

    /// <summary>Provide a parameter value for the Ogden coefficient &amp;alpha;2.</summary>
    [JsonPropertyName("alpha2")]
    public double? Alpha2 { get; set; }

    [JsonPropertyName("mu3")]
    public Dimensional_Pressure? Mu3 { get; set; }

    /// <summary>Provide a parameter value for the Ogden coefficient &amp;alpha;3.</summary>
    [JsonPropertyName("alpha3")]
    public double? Alpha3 { get; set; }

}
