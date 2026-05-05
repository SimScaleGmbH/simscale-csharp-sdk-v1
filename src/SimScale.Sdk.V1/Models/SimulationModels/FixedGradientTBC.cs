using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedGradientTBC : OneOf_CustomFluidBCTemperature
{
    /// <summary>Schema name: FixedGradientTBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_GRADIENT";

    [JsonPropertyName("gradient")]
    public DimensionalFunction_TemperatureGradient? Gradient { get; set; }

}
