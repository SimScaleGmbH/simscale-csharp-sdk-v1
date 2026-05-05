using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FanPressureDropMomentumSource : OneOf_AdvancedConceptsMomentumSources
{
    /// <summary>Schema name: FanPressureDropMomentumSource</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FAN_PRESSURE_DROP";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fanDirection")]
    public DimensionalVector_Dimensionless? FanDirection { get; set; }

    [JsonPropertyName("fanPressure")]
    public DimensionalFunction_Pressure? FanPressure { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
