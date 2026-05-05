using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MRFRotatingZone : OneOf_AdvancedConceptsRotatingZones
{
    /// <summary>Schema name: MRFRotatingZone</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MULTI_REFERENCE_FRAME";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("origin")]
    public DimensionalVector_Length? Origin { get; set; }

    [JsonPropertyName("axis")]
    public DimensionalVector_Length? Axis { get; set; }

    [JsonPropertyName("angularVelocity")]
    public DimensionalFunction_RotationSpeed? AngularVelocity { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
