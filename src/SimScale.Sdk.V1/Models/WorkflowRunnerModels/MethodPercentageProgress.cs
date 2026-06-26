using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Percentage progress value.</summary>
public class MethodPercentageProgress
{
    [JsonPropertyName("value")]
    public int? Value { get; set; }

}
