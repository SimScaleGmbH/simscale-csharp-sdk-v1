using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Chestnut : OneOf_PorousTreeTreeType
{
    /// <summary>Schema name: Chestnut</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CHESTNUT";

    [JsonPropertyName("averageTreeHeight")]
    public Dimensional_Length? AverageTreeHeight { get; set; }

}
