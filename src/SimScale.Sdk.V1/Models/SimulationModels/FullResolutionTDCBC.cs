using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FullResolutionTDCBC : OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressible
{
    /// <summary>Schema name: FullResolutionTDCBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FULL_RESOLUTION";

    [JsonPropertyName("prandtlNumber")]
    public double? PrandtlNumber { get; set; }

}
