using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedGradientPFBC : OneOf_CustomFluidBCPhaseFraction
{
    /// <summary>Schema name: FixedGradientPFBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_GRADIENT";

    [JsonPropertyName("gradient")]
    public Dimensional_PhaseFractionGradient? Gradient { get; set; }

}
