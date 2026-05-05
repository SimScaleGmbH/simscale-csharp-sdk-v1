using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RotatingWallVBC : OneOf_CustomFluidBCVelocity, OneOf_WallBCVelocity
{
    /// <summary>Schema name: RotatingWallVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ROTATING_WALL_VELOCITY";

    [JsonPropertyName("rotation")]
    public AngularRotation? Rotation { get; set; }

    [JsonPropertyName("turbulenceWall")]
    public string? TurbulenceWall { get; set; }

    [JsonPropertyName("wallContactModel")]
    public List<WallContactAngle>? WallContactModel { get; set; }

}
