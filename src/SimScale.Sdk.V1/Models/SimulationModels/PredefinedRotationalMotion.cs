using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PredefinedRotationalMotion
{
    /// <summary>Schema name: PredefinedRotationalMotion</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PREDEFINED_ROTATIONAL_MOTION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("angularVelocity")]
    public DimensionalFunction_RotationSpeed? AngularVelocity { get; set; }

    [JsonPropertyName("rotationCenter")]
    public DimensionalVector_Length? RotationCenter { get; set; }

    [JsonPropertyName("rotationAxis")]
    public DimensionalVector_Length? RotationAxis { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
