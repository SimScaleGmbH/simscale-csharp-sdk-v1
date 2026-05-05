using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedGradientPBC : OneOf_CustomFluidBCPressure, OneOf_CustomFluidBCPressureRgh, OneOf_CustomFluidBCGaugePressure, OneOf_CustomFluidBCGaugePressureRgh
{
    /// <summary>Schema name: FixedGradientPBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_GRADIENT";

    [JsonPropertyName("gradient")]
    public Dimensional_ForceDensity? Gradient { get; set; }

}
