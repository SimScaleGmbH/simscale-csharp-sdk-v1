using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Refine specific faces of interest or complex geometrical shapes by defining a local element size. This will ensure a relatively uniform mesh.</summary>
public class SimmetrixLocalSizingRefinement : OneOf_SimmetrixMeshingSolidRefinements, OneOf_SimmetrixMeshingFluidRefinements, OneOf_SimmetrixMeshingElectromagneticsRefinements
{
    /// <summary>Refine specific faces of interest or complex geometrical shapes by defining a local element size. This will ensure a...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIMMETRIX_LOCAL_SIZING_V10";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("maxElementSize")]
    public Dimensional_Length? MaxElementSize { get; set; }

    [JsonPropertyName("curvature")]
    public OneOf_SimmetrixLocalSizingRefinementCurvature? Curvature { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
