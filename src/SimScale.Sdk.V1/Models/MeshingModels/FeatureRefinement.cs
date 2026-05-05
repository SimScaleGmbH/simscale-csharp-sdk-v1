using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>A feature refinement can be used to refine the geometry’s feature edges. All edges whose adjacent surface normals form an angle of less than 150° will be refined.</summary>
public class FeatureRefinement
{
    /// <summary>A feature refinement can be used to refine the geometry’s feature edges. All edges whose adjacent surface normals for...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "FEATURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("includedAngle")]
    public Dimensional_Angle? IncludedAngle { get; set; }

    /// <summary>This dynamic table allows you to add refinements to the mesh associated with the features (e.g. edges) in a specific...</summary>
    [JsonPropertyName("distanceRefinementLevels")]
    public List<RefinementLevel>? DistanceRefinementLevels { get; set; }

}
