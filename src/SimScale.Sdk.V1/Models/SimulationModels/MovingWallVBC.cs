using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MovingWallVBC : OneOf_CustomFluidBCVelocity, OneOf_WallBCVelocity
{
    /// <summary>Schema name: MovingWallVBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MOVING_WALL_VELOCITY";

    [JsonPropertyName("value")]
    public DimensionalVector_Speed? Value { get; set; }

    [JsonPropertyName("turbulenceWall")]
    public string? TurbulenceWall { get; set; }

    [JsonPropertyName("orientationReference")]
    public string? OrientationReference { get; set; }

    [JsonPropertyName("wallContactModel")]
    public List<WallContactAngle>? WallContactModel { get; set; }

}
