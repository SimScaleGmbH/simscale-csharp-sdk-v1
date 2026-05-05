using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class ManualMeshGrading : OneOf_ManualMeshSizingGrading
{
    /// <summary>Schema name: ManualMeshGrading</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MANUAL";

    /// <summary>This value defines the minimum number of elements along a geometry edge.</summary>
    [JsonPropertyName("numberOfSegmentsPerEdge")]
    public double? NumberOfSegmentsPerEdge { get; set; }

    /// <summary>This value defines the minimum number of elements along a geometry radius.</summary>
    [JsonPropertyName("numberOfSegmentsPerRadius")]
    public double? NumberOfSegmentsPerRadius { get; set; }

    /// <summary>The growth rate determines how large the allowed difference in element size between neighbouring elements is. For exa...</summary>
    [JsonPropertyName("growthRate")]
    public double? GrowthRate { get; set; }

}
