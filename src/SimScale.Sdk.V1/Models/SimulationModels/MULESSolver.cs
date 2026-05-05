using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MULESSolver
{
    /// <summary>Schema name: MULESSolver</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MULES_V7";

    [JsonPropertyName("alphaCorrectors")]
    public int? AlphaCorrectors { get; set; }

    [JsonPropertyName("alphaSubCycles")]
    public int? AlphaSubCycles { get; set; }

    [JsonPropertyName("compressionCoefficient")]
    public double? CompressionCoefficient { get; set; }

    [JsonPropertyName("isotropicCompressionCoefficient")]
    public double? IsotropicCompressionCoefficient { get; set; }

    [JsonPropertyName("semiImplicit")]
    public OneOf_MULESSolverSemiImplicit? SemiImplicit { get; set; }

}
