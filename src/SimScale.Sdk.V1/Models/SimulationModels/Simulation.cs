using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Simulation
{
    [JsonPropertyName("simulationId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid SimulationId { get; set; }

    /// <summary>The name of the simulation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}
