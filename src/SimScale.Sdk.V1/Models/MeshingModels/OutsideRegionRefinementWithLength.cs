using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class OutsideRegionRefinementWithLength : OneOf_RegionRefinementWithLengthRefinement
{
    /// <summary>Schema name: OutsideRegionRefinementWithLength</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OUTSIDE";

    [JsonPropertyName("length")]
    public Dimensional_Length? Length { get; set; }

}
