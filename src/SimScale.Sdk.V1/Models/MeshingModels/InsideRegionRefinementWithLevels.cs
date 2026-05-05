using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class InsideRegionRefinementWithLevels : OneOf_RegionRefinementWithLevelsRefinement
{
    /// <summary>Schema name: InsideRegionRefinementWithLevels</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INSIDE";

    [JsonPropertyName("level")]
    public int? Level { get; set; }

}
