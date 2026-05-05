using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WallFunctionTKEBC : OneOf_CustomFluidBCTurbulentKineticEnergy
{
    /// <summary>Schema name: WallFunctionTKEBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WALL_FUNCTION";

    [JsonPropertyName("wallRoughness")]
    public bool? WallRoughness { get; set; }

    [JsonPropertyName("roughnessHeight")]
    public Dimensional_Length? RoughnessHeight { get; set; }

    [JsonPropertyName("roughnessConstant")]
    public double? RoughnessConstant { get; set; }

}
