using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Workflow run information to be presented for the initialization.</summary>
public class InitializeWorkflowRunRequest
{
    [JsonPropertyName("workflowRunMode")]
    [JsonRequired]
    public required string WorkflowRunMode { get; set; }

    [JsonPropertyName("workflowRunName")]
    public string? WorkflowRunName { get; set; }

    /// <summary>Workflow version identifier. It is a string composed of the type identifier and a UUID: `workflow.version:[UUID]`.</summary>
    [JsonPropertyName("workflowVersionId")]
    [JsonRequired]
    public required string WorkflowVersionId { get; set; }

}
