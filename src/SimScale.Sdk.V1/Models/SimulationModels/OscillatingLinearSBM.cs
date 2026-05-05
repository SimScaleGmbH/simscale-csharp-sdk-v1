using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OscillatingLinearSBM : OneOf_AdvancedConceptsSolidBodyMotions
{
    /// <summary>Schema name: OscillatingLinearSBM</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OSCILLATING_LINEAR_MOTION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("amplitude")]
    public DimensionalVector_Length? Amplitude { get; set; }

    [JsonPropertyName("angularVelocity")]
    public Dimensional_RotationSpeed? AngularVelocity { get; set; }

}
