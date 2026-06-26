using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Represents the progress of a workflow run</summary>
public class WorkflowRunProgress
{
    [JsonPropertyName("elapsedTimeInSeconds")]
    public long? ElapsedTimeInSeconds { get; set; }

    [JsonPropertyName("estimatedRemainingTimeInSeconds")]
    public long? EstimatedRemainingTimeInSeconds { get; set; }

    [JsonPropertyName("finished")]
    public List<OperationRunProgress>? Finished { get; set; }

    [JsonPropertyName("pending")]
    public List<OperationRunProgress>? Pending { get; set; }

    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    [JsonPropertyName("running")]
    public List<OperationRunProgress>? Running { get; set; }

    [JsonPropertyName("skipped")]
    public List<OperationRunProgress>? Skipped { get; set; }

    /// <summary>Workflow run identifier. It is a string composed of the type identifier and a UUID: `workflow.run:[UUID]`.</summary>
    [JsonPropertyName("workflowRunId")]
    public string? WorkflowRunId { get; set; }

}
