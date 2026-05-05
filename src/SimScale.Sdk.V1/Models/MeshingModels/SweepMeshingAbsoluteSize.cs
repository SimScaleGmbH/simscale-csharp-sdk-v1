using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class SweepMeshingAbsoluteSize : OneOf_SimmetrixExtrusionMeshRefinementSizingType, OneOf_SimmetrixSweptMeshRefinementSizingType, OneOf_SimmetrixThinSectionMeshRefinementSizingType
{
    /// <summary>Schema name: SweepMeshingAbsoluteSize</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SWEEP_MESHING_ABSOLUTE_SIZE";

    [JsonPropertyName("thickness")]
    public Dimensional_Length? Thickness { get; set; }

}
