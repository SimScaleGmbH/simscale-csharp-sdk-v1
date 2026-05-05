using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class RelativeDistance : OneOf_SimmetrixThinSectionMeshRefinementDistanceType
{
    /// <summary>Schema name: RelativeDistance</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "RELATIVE";

    [JsonPropertyName("relativeDistance")]
    public double? RelativeDistanceValue { get; set; }

}
