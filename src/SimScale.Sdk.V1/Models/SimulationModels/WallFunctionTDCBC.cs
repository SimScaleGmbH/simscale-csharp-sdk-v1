using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WallFunctionTDCBC : OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressible
{
    /// <summary>Schema name: WallFunctionTDCBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WALL_FUNCTION";

    [JsonPropertyName("prandtlNumber")]
    public double? PrandtlNumber { get; set; }

}
