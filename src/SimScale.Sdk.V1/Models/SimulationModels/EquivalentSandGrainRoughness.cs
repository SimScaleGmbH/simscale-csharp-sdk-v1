using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class EquivalentSandGrainRoughness : OneOf_SurfaceRoughnessModelSurfaceRoughnessType
{
    /// <summary>Schema name: EquivalentSandGrainRoughness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "EQUIVALENT_SAND_GRAIN_ROUGHNESS";

    [JsonPropertyName("surfaceRoughness")]
    public Dimensional_Length? SurfaceRoughness { get; set; }

}
