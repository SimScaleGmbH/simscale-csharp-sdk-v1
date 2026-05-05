using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GaussInterfaceCompressionDivergenceScheme : OneOf_DivergenceSchemesDiv_phirb_alpha, OneOf_DivergenceSchemesDiv_phi_alpha
{
    /// <summary>Schema name: GaussInterfaceCompressionDivergenceScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GAUSS_INTERFACECOMPRESSION";

}
