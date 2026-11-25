using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticMotion
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("motionMethod")]
    public string? MotionMethod { get; set; }

    [JsonPropertyName("motion")]
    public OneOf_ElectromagneticMotionMotion? Motion { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
