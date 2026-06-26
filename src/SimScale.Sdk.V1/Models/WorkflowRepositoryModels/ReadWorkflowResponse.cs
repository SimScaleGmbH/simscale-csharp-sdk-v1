using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.WorkflowsModels;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRepositoryModels;

/// <summary>Workflow or workflow version reading response. Contains all properties available for the requested workflow or workflow version.</summary>
public class ReadWorkflowResponse
{
    [JsonPropertyName("breakpoints")]
    public List<Breakpoint>? Breakpoints { get; set; }

    [JsonPropertyName("configuration")]
    public JsonElement? Configuration { get; set; }

    [JsonPropertyName("createdBy")]
    public int? CreatedBy { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("inputDataMap")]
    public JsonElement? InputDataMap { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Workflow version identifier. It is a string composed of the type identifier and a UUID: `workflow.version:[UUID]`.</summary>
    [JsonPropertyName("parentWorkflowVersionId")]
    public string? ParentWorkflowVersionId { get; set; }

    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }

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
