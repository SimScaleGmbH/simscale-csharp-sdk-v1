using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class AbsoluteDistance : OneOf_SimmetrixThinSectionMeshRefinementDistanceType
{
    /// <summary>Schema name: AbsoluteDistance</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ABSOLUTE";

    [JsonPropertyName("absoluteDistance")]
    public Dimensional_Length? AbsoluteDistanceValue { get; set; }

}
