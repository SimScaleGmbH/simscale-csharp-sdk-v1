using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ZeroGradientPFBC : OneOf_CustomFluidBCPhaseFraction, OneOf_WallBCPhaseFraction
{
    /// <summary>Schema name: ZeroGradientPFBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ZERO_GRADIENT";

}
