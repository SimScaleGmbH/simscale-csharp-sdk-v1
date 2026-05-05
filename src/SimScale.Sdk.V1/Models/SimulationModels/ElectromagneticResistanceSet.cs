using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticResistanceSet
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("entryPort")]
    public TopologicalReference? EntryPort { get; set; }

    [JsonPropertyName("exitPort")]
    public TopologicalReference? ExitPort { get; set; }

}
