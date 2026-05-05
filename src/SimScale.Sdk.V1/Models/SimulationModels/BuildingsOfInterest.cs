using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class BuildingsOfInterest : OneOf_PacefishAutomeshPrimaryTopology
{
    /// <summary>Schema name: BuildingsOfInterest</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BUILDINGS_OF_INTEREST";

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
