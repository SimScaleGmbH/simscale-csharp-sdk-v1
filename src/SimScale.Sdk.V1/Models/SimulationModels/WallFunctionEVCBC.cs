using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WallFunctionEVCBC : OneOf_CustomFluidBCEddyViscosityCompressible
{
    /// <summary>Schema name: WallFunctionEVCBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WALL_FUNCTION";

}
