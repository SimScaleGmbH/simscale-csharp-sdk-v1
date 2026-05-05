using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PlaneTree : OneOf_PorousTreeTreeType
{
    /// <summary>Schema name: PlaneTree</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PLANE_TREE";

    [JsonPropertyName("averageTreeHeight")]
    public Dimensional_Length? AverageTreeHeight { get; set; }

}
