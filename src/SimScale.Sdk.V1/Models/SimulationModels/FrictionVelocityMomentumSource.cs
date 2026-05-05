using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FrictionVelocityMomentumSource : OneOf_AdvancedConceptsMomentumSources
{
    /// <summary>Schema name: FrictionVelocityMomentumSource</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FRICTION_VELOCITY_SOURCE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("frictionVelocity")]
    public DimensionalVector_Speed? FrictionVelocity { get; set; }

    [JsonPropertyName("relaxationFactor")]
    public double? RelaxationFactor { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
