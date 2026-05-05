using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TestsolverSimulationControl
{
    /// <summary>Selecting more processor cores will speed up the simulation process. Choosing a smaller computation instance will sav...</summary>
    [JsonPropertyName("numProcessors")]
    public long? NumProcessors { get; set; }

    [JsonPropertyName("maxRunTime")]
    public Dimensional_Time? MaxRunTime { get; set; }

    [JsonPropertyName("executionMode")]
    public string? ExecutionMode { get; set; }

    [JsonPropertyName("executionModeConfig")]
    public string? ExecutionModeConfig { get; set; }

}
