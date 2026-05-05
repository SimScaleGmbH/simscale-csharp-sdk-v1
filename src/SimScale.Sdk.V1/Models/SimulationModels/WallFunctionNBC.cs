using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WallFunctionNBC : OneOf_CustomFluidBCNuTilda
{
    /// <summary>Schema name: WallFunctionNBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WALL_FUNCTION";

}
