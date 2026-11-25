using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OneTerm : OneOf_OgdenHyperelasticModelMarcNumberOfTerms
{
    /// <summary>Schema name: OneTerm</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ONE_TERM";

    [JsonPropertyName("modulus1Function")]
    public DimensionalFunction_Pressure? Modulus1Function { get; set; }

    [JsonPropertyName("exponent1Function")]
    public OneOf_OneTermExponent1Function? Exponent1Function { get; set; }

}
