using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PerforatedPlate : OneOf_AdvancedConceptsPorousMediums
{
    /// <summary>Schema name: PerforatedPlate</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PERFORATED_PLATE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("plateData")]
    public PlateData? PlateData { get; set; }

    [JsonPropertyName("darcyForchheimerType")]
    public RectifyingDarcyForchheimer? DarcyForchheimerType { get; set; }

    [JsonPropertyName("porousMediaHeatTransfer")]
    public OneOf_PerforatedPlatePorousMediaHeatTransfer? PorousMediaHeatTransfer { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
