using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ZeroGradientEVBC : OneOf_CustomFluidBCEddyViscosity
{
    /// <summary>Schema name: ZeroGradientEVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ZERO_GRADIENT";

}
