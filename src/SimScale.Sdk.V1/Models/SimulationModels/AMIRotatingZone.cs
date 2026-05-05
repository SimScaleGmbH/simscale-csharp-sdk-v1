using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AMIRotatingZone : OneOf_AdvancedConceptsRotatingZones
{
    /// <summary>Schema name: AMIRotatingZone</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ARBITRARY_MESH_INTERFACE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("motionType")]
    public OneOf_AMIRotatingZoneMotionType? MotionType { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
