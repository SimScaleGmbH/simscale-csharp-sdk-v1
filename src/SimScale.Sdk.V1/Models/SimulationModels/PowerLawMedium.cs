using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PowerLawMedium : OneOf_AdvancedConceptsPorousMediums
{
    /// <summary>Schema name: PowerLawMedium</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "POWER_LAW";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("linearCoefficient")]
    public double? LinearCoefficient { get; set; }

    [JsonPropertyName("exponentCoefficient")]
    public double? ExponentCoefficient { get; set; }

    [JsonPropertyName("porousMediaHeatTransfer")]
    public OneOf_PowerLawMediumPorousMediaHeatTransfer? PorousMediaHeatTransfer { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
