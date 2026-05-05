using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Round : OneOf_LitzWireCoilStrandCrossSectionType
{
    /// <summary>Schema name: Round</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ROUND";

    [JsonPropertyName("strandDiameter")]
    public Dimensional_Length? StrandDiameter { get; set; }

}
