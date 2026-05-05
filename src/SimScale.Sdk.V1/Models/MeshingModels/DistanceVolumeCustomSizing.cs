using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class DistanceVolumeCustomSizing : OneOf_VolumeCustomSizingCustomSizingModes
{
    /// <summary>Schema name: DistanceVolumeCustomSizing</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISTANCE_CUSTOM_SIZING";

    /// <summary>Define mesh element sizes inside and around the selected volumes. Each row specifies how the mesh size changes with t...</summary>
    [JsonPropertyName("distanceSizingValues")]
    public List<DistanceSizing>? DistanceSizingValues { get; set; }

    [JsonPropertyName("curvature")]
    public OneOf_DistanceVolumeCustomSizingCurvature? Curvature { get; set; }

}
