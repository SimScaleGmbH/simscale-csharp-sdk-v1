using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoSlipWallAerodynamicRoughness : OneOf_NoSlipVBCNoSlipWallRoughnessType
{
    /// <summary>Schema name: NoSlipWallAerodynamicRoughness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NO_SLIP_WALL_AERODYNAMIC_ROUGHNESS";

    [JsonPropertyName("surfaceRoughness")]
    public Dimensional_Length? SurfaceRoughness { get; set; }

}
