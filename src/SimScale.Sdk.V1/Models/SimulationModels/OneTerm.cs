using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OneTerm : OneOf_OgdenHyperelasticModelMarcNumberOfTerms
{
    /// <summary>Schema name: OneTerm</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ONE_TERM";

    [JsonPropertyName("modulus1")]
    public Dimensional_Pressure? Modulus1 { get; set; }

    [JsonPropertyName("exponent1")]
    public double? Exponent1 { get; set; }

}
