using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.WorkflowRepositoryModels;

namespace SimScale.Sdk.V1.Resources;

public class WorkflowRepository
{
    private readonly SimScaleClient _client;

    public WorkflowRepository(SimScaleClient client) => _client = client;

    /// <summary>Create a new workflow with its initial version.</summary>
    public string CreateWorkflow(
        CreateWorkflowRequest body
    )
    {
        return _client.Request<string>(HttpMethod.Post, $"/workflow-repository/workflows", body);
    }

    /// <summary>List the versions of a workflow.</summary>
    public List<WorkflowVersionOverview> ListWorkflowVersions(
        string workflowId,
        int? page = null,
        int? size = null,
        string? sortBy = null
    )
    {
        return _client.Request<List<WorkflowVersionOverview>>(HttpMethod.Get, $"/workflow-repository/workflows/{workflowId}/versions",
            queryParams: new Dictionary<string, object?> { ["page"] = page, ["size"] = size, ["sortBy"] = sortBy });
    }

    /// <summary>List workflows in a project.</summary>
    public List<WorkflowOverview> ListWorkflows(
        string projectId,
        int? page = null,
        int? size = null,
        string? sortBy = null
    )
    {
        return _client.Request<List<WorkflowOverview>>(HttpMethod.Get, $"/workflow-repository/projects/{projectId}/workflows",
            queryParams: new Dictionary<string, object?> { ["page"] = page, ["size"] = size, ["sortBy"] = sortBy });
    }

    /// <summary>Read a workflow at its latest version.</summary>
    public ReadWorkflowResponse ReadWorkflow(
        string workflowId
    )
    {
        return _client.Request<ReadWorkflowResponse>(HttpMethod.Get, $"/workflow-repository/workflows/{workflowId}");
    }

    /// <summary>Read a specific workflow version.</summary>
    public ReadWorkflowResponse ReadWorkflowVersion(
        string workflowVersionId,
        bool? populateDefaultValues = null
    )
    {
        return _client.Request<ReadWorkflowResponse>(HttpMethod.Get, $"/workflow-repository/workflow-versions/{workflowVersionId}",
            queryParams: new Dictionary<string, object?> { ["populateDefaultValues"] = populateDefaultValues });
    }

    /// <summary>Update a workflow by creating a new version.</summary>
    public string UpdateWorkflow(
        string workflowVersionId,
        UpdateWorkflowRequest body
    )
    {
        return _client.Request<string>(HttpMethod.Post, $"/workflow-repository/workflow-versions/{workflowVersionId}", body);
    }
}
