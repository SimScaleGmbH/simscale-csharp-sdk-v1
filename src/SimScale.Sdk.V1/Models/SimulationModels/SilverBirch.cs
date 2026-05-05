using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SilverBirch : OneOf_PorousTreeTreeType
{
    /// <summary>Schema name: SilverBirch</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SILVER_BIRCH";

    [JsonPropertyName("averageTreeHeight")]
    public Dimensional_Length? AverageTreeHeight { get; set; }

}
