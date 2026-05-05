using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PressureLossCurve : OneOf_AdvancedConceptsPorousMediums
{
    /// <summary>Schema name: PressureLossCurve</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE_LOSS_CURVE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pressureLossData")]
    public PressureLossData? PressureLossData { get; set; }

    [JsonPropertyName("directionalDependency")]
    public DirectionalDependency? DirectionalDependency { get; set; }

    [JsonPropertyName("porousMediaHeatTransfer")]
    public OneOf_PressureLossCurvePorousMediaHeatTransfer? PorousMediaHeatTransfer { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
