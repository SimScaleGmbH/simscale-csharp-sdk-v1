using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>A feature refinement can be used to refine the geometry’s feature edges. All edges whose adjacent surface normals form an angle of less than 150° will be refined.</summary>
public class FeatureRefinementHexDominantSnappy : OneOf_HexDominantSnappyRefinements
{
    /// <summary>A feature refinement can be used to refine the geometry’s feature edges. All edges whose adjacent surface normals for...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FEATURE_HEX_DOMINANT_SNAPPY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify the desired target cell edge length based on the distance to the feature edges. The edge and surface mesh wil...</summary>
    [JsonPropertyName("distanceRefinementLengths")]
    public List<RefinementLength>? DistanceRefinementLengths { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
