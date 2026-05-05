using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.SimulationModels;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class InsideRegionRefinementWithLength : OneOf_RegionRefinementEBMRefinement, OneOf_RegionRefinementWithLengthRefinement
{
    /// <summary>Schema name: InsideRegionRefinementWithLength</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INSIDE";

    [JsonPropertyName("length")]
    public Dimensional_Length? Length { get; set; }

}
