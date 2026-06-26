using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.WorkflowRunnerModels;

namespace SimScale.Sdk.V1.Resources;

public class WorkflowRunner
{
    private readonly SimScaleClient _client;

    public WorkflowRunner(SimScaleClient client) => _client = client;

    /// <summary>Cancel a workflow run.</summary>
    public void CancelWorkflowRun(
        string workflowRunId
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/workflow-runner/runs/{workflowRunId}/cancel");
    }

    /// <summary>Read a method run's resource-usage report.</summary>
    public MethodResourceUsageReport GetMethodRunResourceUsageReport(
        string methodRunId
    )
    {
        return _client.Request<MethodResourceUsageReport>(HttpMethod.Get, $"/workflow-runner/method-runs/{methodRunId}/resource-usage");
    }

    /// <summary>Read an operation run.</summary>
    public OperationRun GetOperationRun(
        string operationRunId
    )
    {
        return _client.Request<OperationRun>(HttpMethod.Get, $"/workflow-runner/operation-runs/{operationRunId}");
    }

    /// <summary>Read a workflow run.</summary>
    public PublicWorkflowRunOverview GetWorkflowRun(
        string workflowRunId
    )
    {
        return _client.Request<PublicWorkflowRunOverview>(HttpMethod.Get, $"/workflow-runner/runs/{workflowRunId}");
    }

    /// <summary>Read the progress of a workflow run.</summary>
    public WorkflowRunProgress GetWorkflowRunProgress(
        string workflowRunId
    )
    {
        return _client.Request<WorkflowRunProgress>(HttpMethod.Get, $"/workflow-runner/runs/{workflowRunId}/progress");
    }

    /// <summary>Initialize a workflow run from a workflow version.</summary>
    public string InitializeWorkflowRun(
        InitializeWorkflowRunRequest body
    )
    {
        return _client.Request<string>(HttpMethod.Post, $"/workflow-runner/runs", body);
    }

    /// <summary>List the workflow runs of a workflow.</summary>
    public List<PublicWorkflowRunOverview> ListWorkflowRunsByWorkflow(
        string workflowId,
        int? page = null,
        int? size = null,
        string? sortBy = null
    )
    {
        return _client.Request<List<PublicWorkflowRunOverview>>(HttpMethod.Get, $"/workflow-runner/workflows/{workflowId}/runs",
            queryParams: new Dictionary<string, object?> { ["page"] = page, ["size"] = size, ["sortBy"] = sortBy });
    }

    /// <summary>Pause a running workflow run.</summary>
    public void PauseWorkflowRun(
        string workflowRunId
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/workflow-runner/runs/{workflowRunId}/pause");
    }

    /// <summary>Resume a paused workflow run.</summary>
    public void ResumeWorkflowRun(
        string workflowRunId
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/workflow-runner/runs/{workflowRunId}/resume");
    }

    /// <summary>Start a workflow run.</summary>
    public void StartWorkflowRun(
        string workflowRunId
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/workflow-runner/runs/{workflowRunId}/start");
    }
}
