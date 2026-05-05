using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class DistanceRegionRefinementWithLength : OneOf_RegionRefinementEBMRefinement
{
    /// <summary>Schema name: DistanceRegionRefinementWithLength</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DISTANCE";

    /// <summary>Define mesh element sizes inside and around the selected volumes. Each row specifies how the mesh size changes with t...</summary>
    [JsonPropertyName("distanceRefinementLengths")]
    public List<RefinementLength>? DistanceRefinementLengths { get; set; }

}
