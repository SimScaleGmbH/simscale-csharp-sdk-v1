using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class RelativeCurvature : OneOf_AutomaticMeshSizingSimmetrixCurvature, OneOf_RegionRefinementWithLengthCurvature, OneOf_ManualMeshSizingSimmetrixCurvature, OneOf_DistanceVolumeCustomSizingCurvature, OneOf_SimmetrixLocalSizingRefinementCurvature, OneOf_CustomMeshSizingSimmetrixCurvature
{
    /// <summary>Schema name: RelativeCurvature</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE_CURVATURE";

    /// <summary>The Number of nodes in a circle defines the relative chordal error on curved features in terms of number of mesh node...</summary>
    [JsonPropertyName("relativeCurvature")]
    public double? RelativeCurvatureValue { get; set; }

}
