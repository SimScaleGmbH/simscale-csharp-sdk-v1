using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Item in the operation run state history. Each history item stores the new state that the operation run has entered at the stored timestamp.</summary>
public class OperationRunStateHistoryItem
{
    [JsonPropertyName("changeTimestamp")]
    public DateTimeOffset? ChangeTimestamp { get; set; }

    /// <summary>Possible states of an operation run.</summary>
    [JsonPropertyName("operationRunState")]
    public string? OperationRunState { get; set; }

}
