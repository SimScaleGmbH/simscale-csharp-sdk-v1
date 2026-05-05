using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DarcyForchheimerMedium : OneOf_AdvancedConceptsPorousMediums
{
    /// <summary>Schema name: DarcyForchheimerMedium</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DARCY_FORCHHEIMER";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("coefficientD")]
    public DimensionalVector_ReciprocalPermeability? CoefficientD { get; set; }

    [JsonPropertyName("coefficientF")]
    public DimensionalVector_Absorptivity? CoefficientF { get; set; }

    [JsonPropertyName("orientation")]
    public OneOf_DarcyForchheimerMediumOrientation? Orientation { get; set; }

    [JsonPropertyName("porousMediaHeatTransfer")]
    public OneOf_DarcyForchheimerMediumPorousMediaHeatTransfer? PorousMediaHeatTransfer { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
