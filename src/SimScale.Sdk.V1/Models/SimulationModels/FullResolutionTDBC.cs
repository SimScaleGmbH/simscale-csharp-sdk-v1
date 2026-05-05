using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FullResolutionTDBC : OneOf_CustomFluidBCTurbulentThermalDiffusivity
{
    /// <summary>Schema name: FullResolutionTDBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FULL_RESOLUTION";

    [JsonPropertyName("prandtlNumber")]
    public double? PrandtlNumber { get; set; }

}
