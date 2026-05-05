using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class OutsideRegionRefinementWithLevels : OneOf_RegionRefinementWithLevelsRefinement
{
    /// <summary>Schema name: OutsideRegionRefinementWithLevels</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OUTSIDE";

    [JsonPropertyName("level")]
    public int? Level { get; set; }

}
