using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomOmegaDissipation : OneOf_VelocityInletBCDissipationType
{
    /// <summary>Schema name: CustomOmegaDissipation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM_DISSIPATION";

    [JsonPropertyName("value")]
    public DimensionalFunction_SpecificTurbulenceDissipationRate? Value { get; set; }

}
