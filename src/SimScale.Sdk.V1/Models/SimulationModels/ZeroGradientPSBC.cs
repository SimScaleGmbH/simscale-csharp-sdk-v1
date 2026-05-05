using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ZeroGradientPSBC : OneOf_CustomFluidBCPassiveScalars
{
    /// <summary>Schema name: ZeroGradientPSBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ZERO_GRADIENT";

}
