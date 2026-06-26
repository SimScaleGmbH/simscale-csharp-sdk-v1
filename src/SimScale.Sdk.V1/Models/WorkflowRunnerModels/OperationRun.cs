using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Operation level information about workflow run.</summary>
public class OperationRun
{
    /// <summary>Reference to a component version. Components are organized into a group hierarchy which serves as a qualification mec...</summary>
    [JsonPropertyName("methodReference")]
    public string? MethodReference { get; set; }

    /// <summary>Method run identifier. It is a string composed of the type identifier and a UUID: `method.run:[UUID]`.</summary>
    [JsonPropertyName("methodRunId")]
    public string? MethodRunId { get; set; }

    /// <summary>Workflow run identifier. It is a string composed of the type identifier and a UUID: `workflow.run:[UUID]`.</summary>
    [JsonPropertyName("nestedWorkflowRunId")]
    public string? NestedWorkflowRunId { get; set; }

    /// <summary>Reference to a component version. Components are organized into a group hierarchy which serves as a qualification mec...</summary>
    [JsonPropertyName("nestedWorkflowTypeReference")]
    public string? NestedWorkflowTypeReference { get; set; }

    [JsonPropertyName("operationName")]
    public string? OperationName { get; set; }

    /// <summary>Operation run identifier. It is a string composed of the type identifier and a UUID: `operation.run:[UUID]`.</summary>
    [JsonPropertyName("operationRunId")]
    public string? OperationRunId { get; set; }

    [JsonPropertyName("operationRunStateHistory")]
    public List<OperationRunStateHistoryItem>? OperationRunStateHistory { get; set; }

    /// <summary>Possible types of an operation run in the workflow run.</summary>
    [JsonPropertyName("operationType")]
    public string? OperationType { get; set; }

    [JsonPropertyName("parameterValues")]
    public Dictionary<string, JsonElement>? ParameterValues { get; set; }

    [JsonPropertyName("recycled")]
    public bool? Recycled { get; set; }

    [JsonPropertyName("stateHistoryStatisticalSummary")]
    public OperationRunStateHistoryStatisticalSummary? StateHistoryStatisticalSummary { get; set; }

    /// <summary>Workflow run identifier. It is a string composed of the type identifier and a UUID: `workflow.run:[UUID]`.</summary>
    [JsonPropertyName("workflowRunId")]
    public string? WorkflowRunId { get; set; }

}
