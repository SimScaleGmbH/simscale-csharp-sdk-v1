using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Details about an individual operation run's progress.</summary>
public class OperationRunProgress
{
    [JsonPropertyName("elapsedTimeInSeconds")]
    public long? ElapsedTimeInSeconds { get; set; }

    [JsonPropertyName("estimatedRemainingTimeInSeconds")]
    public long? EstimatedRemainingTimeInSeconds { get; set; }

    [JsonPropertyName("methodProgress")]
    public List<MethodProgressEntry>? MethodProgress { get; set; }

    /// <summary>Method run identifier. It is a string composed of the type identifier and a UUID: `method.run:[UUID]`.</summary>
    [JsonPropertyName("methodRunId")]
    public string? MethodRunId { get; set; }

    [JsonPropertyName("nestedRunProgress")]
    public JsonElement? NestedRunProgress { get; set; }

    /// <summary>Workflow run identifier. It is a string composed of the type identifier and a UUID: `workflow.run:[UUID]`.</summary>
    [JsonPropertyName("nestedWorkflowRunId")]
    public string? NestedWorkflowRunId { get; set; }

    [JsonPropertyName("operationLabel")]
    public string? OperationLabel { get; set; }

    [JsonPropertyName("operationMultiLanguageLabel")]
    public Dictionary<string, string>? OperationMultiLanguageLabel { get; set; }

    [JsonPropertyName("operationName")]
    public string? OperationName { get; set; }

    /// <summary>Operation run identifier. It is a string composed of the type identifier and a UUID: `operation.run:[UUID]`.</summary>
    [JsonPropertyName("operationRunId")]
    public string? OperationRunId { get; set; }

    /// <summary>Possible types of an operation run in the workflow run.</summary>
    [JsonPropertyName("operationType")]
    public string? OperationType { get; set; }

    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

}
