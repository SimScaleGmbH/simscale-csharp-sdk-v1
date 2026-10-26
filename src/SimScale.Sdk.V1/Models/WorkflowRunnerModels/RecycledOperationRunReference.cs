using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Reference to the earlier operation run whose results a recycled operation run reuses: the workflow run and operation that originally produced them, and the execution behind it.</summary>
public class RecycledOperationRunReference
{
    /// <summary>Method run identifier. It is a string composed of the type identifier and a UUID: `method.run:[UUID]`.</summary>
    [JsonPropertyName("methodRunId")]
    public string? MethodRunId { get; set; }

    /// <summary>Workflow run identifier. It is a string composed of the type identifier and a UUID: `workflow.run:[UUID]`.</summary>
    [JsonPropertyName("nestedWorkflowRunId")]
    public string? NestedWorkflowRunId { get; set; }

    [JsonPropertyName("operationName")]
    public string? OperationName { get; set; }

    /// <summary>Operation run identifier. It is a string composed of the type identifier and a UUID: `operation.run:[UUID]`.</summary>
    [JsonPropertyName("operationRunId")]
    public string? OperationRunId { get; set; }

    /// <summary>Workflow run identifier. It is a string composed of the type identifier and a UUID: `workflow.run:[UUID]`.</summary>
    [JsonPropertyName("workflowRunId")]
    public string? WorkflowRunId { get; set; }

}
