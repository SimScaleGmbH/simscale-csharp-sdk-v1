using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AverageVelocityMomentumSource : OneOf_AdvancedConceptsMomentumSources
{
    /// <summary>Schema name: AverageVelocityMomentumSource</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AVERAGE_VELOCITY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("averageVelocity")]
    public DimensionalVector_Speed? AverageVelocity { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
