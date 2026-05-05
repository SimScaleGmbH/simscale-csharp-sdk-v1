using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GaussLinearUpwindVGradUDivergenceScheme : OneOf_DivergenceSchemesDiv_Phi_velocity, OneOf_DivergenceSchemesDiv_rhoPhi_velocity
{
    /// <summary>Schema name: GaussLinearUpwindVGradUDivergenceScheme</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GAUSS_LINEARUPWINDV_GRAD_U_";

}
