using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ThreeTerms : OneOf_OgdenHyperelasticModelMarcNumberOfTerms
{
    /// <summary>Schema name: ThreeTerms</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "THREE_TERMS";

    [JsonPropertyName("modulus1")]
    public Dimensional_Pressure? Modulus1 { get; set; }

    [JsonPropertyName("exponent1")]
    public double? Exponent1 { get; set; }

    [JsonPropertyName("modulus2")]
    public Dimensional_Pressure? Modulus2 { get; set; }

    [JsonPropertyName("exponent2")]
    public double? Exponent2 { get; set; }

    [JsonPropertyName("modulus3")]
    public Dimensional_Pressure? Modulus3 { get; set; }

    [JsonPropertyName("exponent3")]
    public double? Exponent3 { get; set; }

}
