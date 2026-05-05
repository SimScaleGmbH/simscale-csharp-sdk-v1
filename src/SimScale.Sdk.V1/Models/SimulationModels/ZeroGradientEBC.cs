using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ZeroGradientEBC : OneOf_CustomFluidBCEpsilonDissipationRate
{
    /// <summary>Schema name: ZeroGradientEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ZERO_GRADIENT";

}
