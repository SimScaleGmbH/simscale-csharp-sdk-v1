using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticCurvature : OneOf_AutomaticMeshSizingSimmetrixCurvature, OneOf_RegionRefinementWithLengthCurvature, OneOf_ManualMeshSizingSimmetrixCurvature, OneOf_DistanceVolumeCustomSizingCurvature, OneOf_SimmetrixLocalSizingRefinementCurvature, OneOf_CustomMeshSizingSimmetrixCurvature
{
    /// <summary>Schema name: AutomaticCurvature</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_CURVATURE";

}
