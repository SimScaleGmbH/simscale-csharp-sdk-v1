using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Square : OneOf_LitzWireCoilStrandCrossSectionType
{
    /// <summary>Schema name: Square</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SQUARE";

    [JsonPropertyName("strandWidth")]
    public Dimensional_Length? StrandWidth { get; set; }

}
