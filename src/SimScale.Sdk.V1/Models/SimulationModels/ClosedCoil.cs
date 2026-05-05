using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ClosedCoil : OneOf_CoilTopology
{
    /// <summary>Schema name: ClosedCoil</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CLOSED_COIL";

    [JsonPropertyName("bodies")]
    public TopologicalReference? Bodies { get; set; }

    [JsonPropertyName("internalPort")]
    public TopologicalReference? InternalPort { get; set; }

}
