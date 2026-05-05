using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SecondOrderOgden : OneOf_OgdenHyperElasticModelOrder
{
    /// <summary>Schema name: SecondOrderOgden</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SECOND_ORDER_OGDEN";

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

}
