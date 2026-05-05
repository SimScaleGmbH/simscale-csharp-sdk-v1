using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedGradientVBC : OneOf_CustomFluidBCVelocity
{
    /// <summary>Schema name: FixedGradientVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_GRADIENT";

    [JsonPropertyName("gradient")]
    public DimensionalVector_SpecificTurbulenceDissipationRate? Gradient { get; set; }

}
