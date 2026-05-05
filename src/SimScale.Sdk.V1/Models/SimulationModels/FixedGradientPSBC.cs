using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedGradientPSBC : OneOf_CustomFluidBCPassiveScalars
{
    /// <summary>Schema name: FixedGradientPSBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_GRADIENT";

    [JsonPropertyName("gradient")]
    public Dimensional_Absorptivity? Gradient { get; set; }

}
