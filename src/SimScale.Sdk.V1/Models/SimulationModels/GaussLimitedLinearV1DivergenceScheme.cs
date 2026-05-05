using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GaussLimitedLinearV1DivergenceScheme : OneOf_DivergenceSchemesDiv_Phi_velocity, OneOf_DivergenceSchemesDiv_rhoPhi_velocity
{
    /// <summary>Schema name: GaussLimitedLinearV1DivergenceScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GAUSS_LIMITEDLINEARV_1";

}
