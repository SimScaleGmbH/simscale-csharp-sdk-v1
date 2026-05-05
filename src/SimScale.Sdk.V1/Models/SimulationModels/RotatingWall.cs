using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RotatingWall
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("origin")]
    public DimensionalVector_Length? Origin { get; set; }

    [JsonPropertyName("axis")]
    public DimensionalVector_Length? Axis { get; set; }

    [JsonPropertyName("rotationalVelocity")]
    public Dimensional_RotationSpeed? RotationalVelocity { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
