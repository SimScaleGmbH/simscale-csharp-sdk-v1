using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.MeshingModels;

namespace SimScale.Sdk.V1.Models;

public class MeshOperation
{
    /// <summary>The mesh operation ID.</summary>
    [JsonPropertyName("meshOperationId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid MeshOperationId { get; set; }

    /// <summary>The name of the mesh operation.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

    /// <summary>The schema version of the mesh operation. This can be either the external version like `8.0`, or the internal version...</summary>
    [JsonPropertyName("version")]
    public string Version { get; set; } = "10.0";

    /// <summary>The ID of CAD input to the mesh operation.</summary>
    [JsonPropertyName("cadId")]
    [JsonRequired]
    public required Guid CadId { get; set; }

    /// <summary>The ID of CAD state input to the mesh operation.</summary>
    [JsonPropertyName("stateId")]
    [JsonRequired]
    public required Guid StateId { get; set; }

    [JsonPropertyName("model")]
    [JsonRequired]
    public required Algorithm Model { get; set; }

    /// <summary>The time the mesh operation was created.</summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>The time the mesh operation was last modified.</summary>
    [JsonPropertyName("modifiedAt")]
    public DateTimeOffset? ModifiedAt { get; set; }

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
