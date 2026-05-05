using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GroundRelative : OneOf_PedestrianComfortSurfaceGround
{
    /// <summary>Schema name: GroundRelative</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GROUND_RELATIVE";

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
