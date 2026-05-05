using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OscillatingRotatingSBM : OneOf_AdvancedConceptsSolidBodyMotions
{
    /// <summary>Schema name: OscillatingRotatingSBM</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OSCILLATING_ROTATING_MOTION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("rotationCenter")]
    public DimensionalVector_Length? RotationCenter { get; set; }

    [JsonPropertyName("amplitude")]
    public DimensionalVector_Angle? Amplitude { get; set; }

    [JsonPropertyName("angularVelocity")]
    public Dimensional_RotationSpeed? AngularVelocity { get; set; }

}
