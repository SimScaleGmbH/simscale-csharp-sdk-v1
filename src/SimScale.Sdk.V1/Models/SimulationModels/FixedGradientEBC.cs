using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedGradientEBC : OneOf_CustomFluidBCEpsilonDissipationRate
{
    /// <summary>Schema name: FixedGradientEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_GRADIENT";

    [JsonPropertyName("gradient")]
    public Dimensional_EpsilonGradient? Gradient { get; set; }

}
