using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedCoeffMedium : OneOf_AdvancedConceptsPorousMediums
{
    /// <summary>Schema name: FixedCoeffMedium</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FIXED_COEFFICIENTS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("alpha")]
    public DimensionalVector_SpecificTurbulenceDissipationRate? Alpha { get; set; }

    [JsonPropertyName("beta")]
    public DimensionalVector_Absorptivity? Beta { get; set; }

    [JsonPropertyName("referenceDensity")]
    public Dimensional_Density? ReferenceDensity { get; set; }

    [JsonPropertyName("orientation")]
    public OneOf_FixedCoeffMediumOrientation? Orientation { get; set; }

    [JsonPropertyName("porousMediaHeatTransfer")]
    public OneOf_FixedCoeffMediumPorousMediaHeatTransfer? PorousMediaHeatTransfer { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
