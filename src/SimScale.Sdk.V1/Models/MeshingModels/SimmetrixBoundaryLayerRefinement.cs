using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Layer inflation allows the creation of prismatic boundary layers for certain mesh regions.Prismatic layers are mostly used in CFD simulations on no-slip walls in order to efficiently capture the boundary layer velocity profile, but they may be also used in certain structural simulations like stamping or deep-drawing processes. The figure shows a sample mesh with boundary layers added.</summary>
public class SimmetrixBoundaryLayerRefinement : OneOf_SimmetrixMeshingFluidRefinements, OneOf_SimmetrixMeshingSolidRefinements
{
    /// <summary>Layer inflation allows the creation of prismatic boundary layers for certain mesh regions.Prismatic layers are mostly...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SIMMETRIX_BOUNDARY_LAYER_V13";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("layerType")]
    public OneOf_SimmetrixBoundaryLayerRefinementLayerType? LayerType { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
