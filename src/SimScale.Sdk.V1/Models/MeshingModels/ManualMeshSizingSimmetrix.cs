using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class ManualMeshSizingSimmetrix : OneOf_SimmetrixMeshingFluidSizing, OneOf_SimmetrixMeshingSolidSizing, OneOf_SimmetrixMeshingElectromagneticsSizing
{
    /// <summary>Schema name: ManualMeshSizingSimmetrix</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL";

    [JsonPropertyName("maximumEdgeLength")]
    public Dimensional_Length? MaximumEdgeLength { get; set; }

    [JsonPropertyName("minimumEdgeLength")]
    public Dimensional_Length? MinimumEdgeLength { get; set; }

    [JsonPropertyName("curvature")]
    public OneOf_ManualMeshSizingSimmetrixCurvature? Curvature { get; set; }

}
