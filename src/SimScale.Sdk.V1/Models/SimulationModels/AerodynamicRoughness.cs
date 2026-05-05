using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AerodynamicRoughness : OneOf_SurfaceRoughnessModelSurfaceRoughnessType
{
    /// <summary>Schema name: AerodynamicRoughness</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AERODYNAMIC_ROUGHNESS";

    [JsonPropertyName("surfaceRoughness")]
    public Dimensional_Length? SurfaceRoughness { get; set; }

}
