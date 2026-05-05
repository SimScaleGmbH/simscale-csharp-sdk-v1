using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Oak : OneOf_PorousTreeTreeType
{
    /// <summary>Schema name: Oak</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OAK";

    [JsonPropertyName("averageTreeHeight")]
    public Dimensional_Length? AverageTreeHeight { get; set; }

}
