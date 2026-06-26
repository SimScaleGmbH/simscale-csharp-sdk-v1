using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Public-API overview of a workflow run. When the run is in the SUCCEEDED state, `outputDataMap` is populated with the DataIds of the run's outputs; in all other states (including in listings) the field is null.</summary>
public class PublicWorkflowRunOverview
{
    [JsonPropertyName("creationTimestamp")]
    public DateTimeOffset? CreationTimestamp { get; set; }

    [JsonPropertyName("error")]
    public JsonElement? Error { get; set; }

    [JsonPropertyName("hasRecycledOperation")]
    public bool? HasRecycledOperation { get; set; }

    [JsonPropertyName("lastProcessed")]
    public DateTimeOffset? LastProcessed { get; set; }

    [JsonPropertyName("outputDataMap")]
    public JsonElement? OutputDataMap { get; set; }

    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Workflow run state is a higher-level state describing overall progression.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Workflow identifier. It is a string composed of the type identifier and a UUID: `workflow:[UUID]`.</summary>
    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    /// <summary>Workflow run identifier. It is a string composed of the type identifier and a UUID: `workflow.run:[UUID]`.</summary>
    [JsonPropertyName("workflowRunId")]
    public string? WorkflowRunId { get; set; }

    [JsonPropertyName("workflowRunMode")]
    public string? WorkflowRunMode { get; set; }

    [JsonPropertyName("workflowRunName")]
    public string? WorkflowRunName { get; set; }

    /// <summary>Reference to a component version. Components are organized into a group hierarchy which serves as a qualification mec...</summary>
    [JsonPropertyName("workflowTypeReference")]
    public string? WorkflowTypeReference { get; set; }

    /// <summary>Workflow version identifier. It is a string composed of the type identifier and a UUID: `workflow.version:[UUID]`.</summary>
    [JsonPropertyName("workflowVersionId")]
    public string? WorkflowVersionId { get; set; }

}
