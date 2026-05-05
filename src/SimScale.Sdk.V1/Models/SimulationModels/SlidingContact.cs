using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SlidingContact : OneOf_ContactConnections
{
    /// <summary>Schema name: SlidingContact</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SLIDING_CONTACT";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("enableHeatTransfer")]
    public string? EnableHeatTransfer { get; set; }

    [JsonPropertyName("positionTolerance")]
    public OneOf_SlidingContactPositionTolerance? PositionTolerance { get; set; }

    [JsonPropertyName("masterTopologicalReference")]
    public TopologicalReference? MasterTopologicalReference { get; set; }

    [JsonPropertyName("slaveTopologicalReference")]
    public TopologicalReference? SlaveTopologicalReference { get; set; }

}
