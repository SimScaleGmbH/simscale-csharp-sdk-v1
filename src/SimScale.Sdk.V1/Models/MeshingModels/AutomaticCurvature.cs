using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticCurvature : OneOf_AutomaticMeshSizingSimmetrixCurvature, OneOf_CustomMeshSizingSimmetrixCurvature, OneOf_SimmetrixLocalSizingRefinementCurvature, OneOf_DistanceVolumeCustomSizingCurvature, OneOf_ManualMeshSizingSimmetrixCurvature, OneOf_RegionRefinementWithLengthCurvature
{
    /// <summary>Schema name: AutomaticCurvature</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_CURVATURE";

}
