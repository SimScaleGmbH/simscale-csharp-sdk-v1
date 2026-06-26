using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRepositoryModels;

/// <summary>Workflow overview data structure. Holds high-level information but skips details (for example data mapping and configuration) to keep the response size reasonably small.</summary>
public class WorkflowOverview
{
    [JsonPropertyName("createdBy")]
    public int? CreatedBy { get; set; }

    [JsonPropertyName("creationTimestamp")]
    public DateTimeOffset? CreationTimestamp { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("lastModificationTimestamp")]
    public DateTimeOffset? LastModificationTimestamp { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Workflow version identifier. It is a string composed of the type identifier and a UUID: `workflow.version:[UUID]`.</summary>
    [JsonPropertyName("parentWorkflowVersionId")]
    public string? ParentWorkflowVersionId { get; set; }

    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Workflow identifier. It is a string composed of the type identifier and a UUID: `workflow:[UUID]`.</summary>
    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    /// <summary>Reference to a component version. Components are organized into a group hierarchy which serves as a qualification mec...</summary>
    [JsonPropertyName("workflowTypeReference")]
    public string? WorkflowTypeReference { get; set; }

    /// <summary>Workflow version identifier. It is a string composed of the type identifier and a UUID: `workflow.version:[UUID]`.</summary>
    [JsonPropertyName("workflowVersionId")]
    public string? WorkflowVersionId { get; set; }

}
