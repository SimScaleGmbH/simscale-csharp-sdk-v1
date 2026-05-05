using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoSlipVBC : OneOf_CustomFluidBCVelocity, OneOf_WallBCVelocity
{
    /// <summary>Schema name: NoSlipVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NO_SLIP";

    [JsonPropertyName("turbulenceWall")]
    public string? TurbulenceWall { get; set; }

    /// <summary>When turned ON, this wall's is no longer considered to be smooth. Its roughness may be then be specified.</summary>
    [JsonPropertyName("enableSurfaceRoughness")]
    public bool? EnableSurfaceRoughness { get; set; }

    [JsonPropertyName("surfaceRoughness")]
    public Dimensional_Length? SurfaceRoughness { get; set; }

    [JsonPropertyName("noSlipWallRoughnessType")]
    public OneOf_NoSlipVBCNoSlipWallRoughnessType? NoSlipWallRoughnessType { get; set; }

    [JsonPropertyName("wallContactModel")]
    public List<WallContactAngle>? WallContactModel { get; set; }

}
