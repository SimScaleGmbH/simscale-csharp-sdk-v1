using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.WorkflowsModels;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRepositoryModels;

/// <summary>Workflow update data structure. Suitable for specifying all mutable properties. Properties which are not presented will not be updated in the workflow.</summary>
public class UpdateWorkflowRequest
{
    [JsonPropertyName("breakpoints")]
    public List<Breakpoint>? Breakpoints { get; set; }

    [JsonPropertyName("configuration")]
    public JsonElement? Configuration { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("inputDataMap")]
    public JsonElement? InputDataMap { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a component version. Components are organized into a group hierarchy which serves as a qualification mec...</summary>
    [JsonPropertyName("workflowTypeVersionReference")]
    public string? WorkflowTypeVersionReference { get; set; }

}
