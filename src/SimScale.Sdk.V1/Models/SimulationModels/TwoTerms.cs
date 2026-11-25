using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TwoTerms : OneOf_OgdenHyperelasticModelMarcNumberOfTerms
{
    /// <summary>Schema name: TwoTerms</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TWO_TERMS";

    [JsonPropertyName("modulus1Function")]
    public DimensionalFunction_Pressure? Modulus1Function { get; set; }

    [JsonPropertyName("exponent1Function")]
    public OneOf_TwoTermsExponent1Function? Exponent1Function { get; set; }

    [JsonPropertyName("modulus2Function")]
    public DimensionalFunction_Pressure? Modulus2Function { get; set; }

    [JsonPropertyName("exponent2Function")]
    public OneOf_TwoTermsExponent2Function? Exponent2Function { get; set; }

}
