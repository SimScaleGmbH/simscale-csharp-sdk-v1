using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class CustomMeshSizingSimmetrix : OneOf_InsideVolumeCustomSizingSizing, OneOf_SurfaceCustomSizingSizing
{
    /// <summary>Schema name: CustomMeshSizingSimmetrix</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM";

    [JsonPropertyName("defaultSize")]
    public Dimensional_Length? DefaultSize { get; set; }

    [JsonPropertyName("minSize")]
    public Dimensional_Length? MinSize { get; set; }

    [JsonPropertyName("curvature")]
    public OneOf_CustomMeshSizingSimmetrixCurvature? Curvature { get; set; }

}
