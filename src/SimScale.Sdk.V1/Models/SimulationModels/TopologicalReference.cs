using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TopologicalReference
{
    [JsonPropertyName("entities")]
    public List<string>? Entities { get; set; }

    [JsonPropertyName("sets")]
    public List<Guid>? Sets { get; set; }

}
