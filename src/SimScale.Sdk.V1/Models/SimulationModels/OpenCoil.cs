using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OpenCoil : OneOf_CoilTopology
{
    /// <summary>Schema name: OpenCoil</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OPEN_COIL";

    [JsonPropertyName("bodies")]
    public TopologicalReference? Bodies { get; set; }

    [JsonPropertyName("entryPort")]
    public TopologicalReference? EntryPort { get; set; }

    [JsonPropertyName("exitPort")]
    public TopologicalReference? ExitPort { get; set; }

}
