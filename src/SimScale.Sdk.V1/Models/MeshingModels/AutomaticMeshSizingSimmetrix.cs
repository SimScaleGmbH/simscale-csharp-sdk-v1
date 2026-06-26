using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AutomaticMeshSizingSimmetrix : OneOf_SimmetrixMeshingFluidSizing, OneOf_SimmetrixMeshingSolidSizing, OneOf_SurfaceCustomSizingSizing, OneOf_InsideVolumeCustomSizingSizing, OneOf_SimmetrixMeshingElectromagneticsSizing
{
    /// <summary>Schema name: AutomaticMeshSizingSimmetrix</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC_V9";

    /// <summary>Adjust the overall mesh sizing from coarse (value: 0) to fine (10).</summary>
    [JsonPropertyName("fineness")]
    public double? Fineness { get; set; }

    [JsonPropertyName("curvature")]
    public OneOf_AutomaticMeshSizingSimmetrixCurvature? Curvature { get; set; }

}
