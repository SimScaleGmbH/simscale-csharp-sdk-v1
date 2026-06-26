using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Statistical summary information about the workflow run state history.</summary>
public class OperationRunStateHistoryStatisticalSummary
{
    [JsonPropertyName("totalDuration")]
    public long? TotalDuration { get; set; }

}
