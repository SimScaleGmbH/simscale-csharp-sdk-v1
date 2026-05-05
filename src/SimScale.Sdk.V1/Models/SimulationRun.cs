using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class SimulationRun
{
    [JsonPropertyName("runId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid RunId { get; set; }

    /// <summary>The name of the simulation run.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    /// <summary>The time when the simulation run was created.</summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>The time when the simulation run was started.</summary>
    [JsonPropertyName("startedAt")]
    public DateTimeOffset? StartedAt { get; set; }

    /// <summary>The time when the simulation run was finished.</summary>
    [JsonPropertyName("finishedAt")]
    public DateTimeOffset? FinishedAt { get; set; }

    /// <summary>The actual duration of the simulation run.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("computeResource")]
    public SimulationRunComputeResource? ComputeResource { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The current progress while the simulation run is in progress.</summary>
    [JsonPropertyName("progress")]
    public double? Progress { get; set; }

}
