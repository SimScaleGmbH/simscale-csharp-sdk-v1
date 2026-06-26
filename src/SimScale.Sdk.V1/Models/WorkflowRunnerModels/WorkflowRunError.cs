using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRunnerModels;

/// <summary>Error information for a failed workflow run. Present only when the run is in the FAILED state.</summary>
public class WorkflowRunError
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public Dictionary<string, string>? Details { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

}
