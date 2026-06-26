using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Standalone resource usage report for one method run.</summary>
public class MethodResourceUsageReport
{
    [JsonPropertyName("allocatedCpus")]
    public int? AllocatedCpus { get; set; }

    [JsonPropertyName("allocatedGpus")]
    public int? AllocatedGpus { get; set; }

    [JsonPropertyName("durationInMillis")]
    public long? DurationInMillis { get; set; }

    [JsonPropertyName("finishedAt")]
    public DateTimeOffset? FinishedAt { get; set; }

    /// <summary>Method run identifier. It is a string composed of the type identifier and a UUID: `method.run:[UUID]`.</summary>
    [JsonPropertyName("methodRunId")]
    public string? MethodRunId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operation run identifier. It is a string composed of the type identifier and a UUID: `operation.run:[UUID]`.</summary>
    [JsonPropertyName("operationRunId")]
    public string? OperationRunId { get; set; }

    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    [JsonPropertyName("runTerminalState")]
    public string? RunTerminalState { get; set; }

    [JsonPropertyName("startedAt")]
    public DateTimeOffset? StartedAt { get; set; }

    /// <summary>Completeness status for resource usage reporting.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("usageSummary")]
    public ResourceUsageSummary? UsageSummary { get; set; }

}
