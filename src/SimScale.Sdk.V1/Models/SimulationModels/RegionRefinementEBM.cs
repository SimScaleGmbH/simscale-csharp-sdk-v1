using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RegionRefinementEBM : OneOf_EmbeddedBoundaryMeshingRefinements
{
    /// <summary>Schema name: RegionRefinementEBM</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION_REFINEMENT_EBM";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("refinement")]
    public OneOf_RegionRefinementEBMRefinement? Refinement { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
