using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvancedModelling
{
    [JsonPropertyName("surfaceRoughnessModels")]
    public List<SurfaceRoughnessModel>? SurfaceRoughnessModels { get; set; }

    [JsonPropertyName("porousObjects")]
    public List<OneOf_AdvancedModellingPorousObjects>? PorousObjects { get; set; }

    [JsonPropertyName("rotatingWalls")]
    public List<RotatingWall>? RotatingWalls { get; set; }

}
