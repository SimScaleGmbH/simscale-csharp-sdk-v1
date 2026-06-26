using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class SweepMeshingNumberOfElements : OneOf_SimmetrixThinSectionMeshRefinementSizingType, OneOf_SimmetrixSweptMeshRefinementSizingType, OneOf_SimmetrixExtrusionMeshRefinementSizingType
{
    /// <summary>Schema name: SweepMeshingNumberOfElements</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SWEEP_MESHING_NUMBER_OF_ELEMENTS";

    [JsonPropertyName("numberOfElements")]
    public int? NumberOfElements { get; set; }

}
