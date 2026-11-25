using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ThreeTerms : OneOf_OgdenHyperelasticModelMarcNumberOfTerms
{
    /// <summary>Schema name: ThreeTerms</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "THREE_TERMS";

    [JsonPropertyName("modulus1Function")]
    public DimensionalFunction_Pressure? Modulus1Function { get; set; }

    [JsonPropertyName("exponent1Function")]
    public OneOf_ThreeTermsExponent1Function? Exponent1Function { get; set; }

    [JsonPropertyName("modulus2Function")]
    public DimensionalFunction_Pressure? Modulus2Function { get; set; }

    [JsonPropertyName("exponent2Function")]
    public OneOf_ThreeTermsExponent2Function? Exponent2Function { get; set; }

    [JsonPropertyName("modulus3Function")]
    public DimensionalFunction_Pressure? Modulus3Function { get; set; }

    [JsonPropertyName("exponent3Function")]
    public OneOf_ThreeTermsExponent3Function? Exponent3Function { get; set; }

}
