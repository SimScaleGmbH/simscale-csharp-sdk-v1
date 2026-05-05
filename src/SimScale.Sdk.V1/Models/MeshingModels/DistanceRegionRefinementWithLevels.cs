using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class DistanceRegionRefinementWithLevels : OneOf_RegionRefinementWithLevelsRefinement
{
    /// <summary>Schema name: DistanceRegionRefinementWithLevels</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISTANCE";

    [JsonPropertyName("distanceRefinementLevels")]
    public List<RefinementLevel>? DistanceRefinementLevels { get; set; }

}
