using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class ProjectCopyResponse
{
    /// <summary>The ID of the project copy operation.</summary>
    [JsonPropertyName("projectCopyId")]
    [JsonRequired]
    public required Guid ProjectCopyId { get; set; }

    [JsonPropertyName("status")]
    [JsonRequired]
    public required string Status { get; set; }

    /// <summary>The ID of the new project when the copy succeeded.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    [JsonPropertyName("failureReason")]
    public LogEntry? FailureReason { get; set; }

}
