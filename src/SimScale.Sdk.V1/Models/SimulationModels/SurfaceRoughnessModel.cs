using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SurfaceRoughnessModel
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("surfaceRoughnessType")]
    public OneOf_SurfaceRoughnessModelSurfaceRoughnessType? SurfaceRoughnessType { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
