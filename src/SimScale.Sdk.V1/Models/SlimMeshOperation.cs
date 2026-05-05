using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class SlimMeshOperation
{
    /// <summary>The mesh operation ID.</summary>
    [JsonPropertyName("meshOperationId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid MeshOperationId { get; set; }

    /// <summary>The name of the mesh operation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The time the mesh operation was started.</summary>
    [JsonPropertyName("startedAt")]
    public DateTimeOffset? StartedAt { get; set; }

    /// <summary>The time the mesh operation was finished.</summary>
    [JsonPropertyName("finishedAt")]
    public DateTimeOffset? FinishedAt { get; set; }

    [JsonPropertyName("computeResource")]
    public MeshOperationComputeResource? ComputeResource { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The current progress while the mesh operation is in progress.</summary>
    [JsonPropertyName("progress")]
    public double? Progress { get; set; }

    /// <summary>The ID of the generated mesh.</summary>
    [JsonPropertyName("meshId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid MeshId { get; set; }

}
