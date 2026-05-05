using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NoSlipWallEquivalentSandRoughness : OneOf_NoSlipVBCNoSlipWallRoughnessType
{
    /// <summary>Schema name: NoSlipWallEquivalentSandRoughness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NO_SLIP_WALL_EQUIVALENT_SAND_ROUGHNESS";

    [JsonPropertyName("surfaceRoughness")]
    public Dimensional_Length? SurfaceRoughness { get; set; }

}
