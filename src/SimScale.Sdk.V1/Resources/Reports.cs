using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.ReportingModels;

namespace SimScale.Sdk.V1.Resources;

public class Reports
{
    private readonly SimScaleClient _client;

    public Reports(SimScaleClient client) => _client = client;

    public void CancelReportJob(
        string projectId,
        Guid reportId
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/projects/{projectId}/reports/{reportId}/cancel");
    }

    public ReportResponse CreateReport(
        string projectId,
        ReportRequest body
    )
    {
        return _client.Request<ReportResponse>(HttpMethod.Post, $"/projects/{projectId}/reports", body);
    }

    public ReportResponse CreateReportFromPostprocessingState(
        string projectId,
        ReportFromStateRequest body
    )
    {
        return _client.Request<ReportResponse>(HttpMethod.Post, $"/projects/{projectId}/reports/from-state", body);
    }

    public void DeleteReport(
        string projectId,
        Guid reportId
    )
    {
        _client.RequestVoid(HttpMethod.Delete, $"/projects/{projectId}/reports/{reportId}");
    }

    public ReportResponse GetReport(
        string projectId,
        Guid reportId
    )
    {
        return _client.Request<ReportResponse>(HttpMethod.Get, $"/projects/{projectId}/reports/{reportId}");
    }

    public PaginatedResponse<ReportResponse> GetReports(
        string projectId,
        Guid? simulationId = null,
        Guid? runId = null,
        int? limit = null,
        int? page = null
    )
    {
        return _client.RequestPaginated<ReportResponse>(HttpMethod.Get, $"/projects/{projectId}/reports",
            queryParams: new Dictionary<string, object?> { ["simulationId"] = simulationId, ["runId"] = runId, ["limit"] = limit, ["page"] = page });
    }

    public void StartReportJob(
        string projectId,
        Guid reportId
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/projects/{projectId}/reports/{reportId}/start");
    }

    public void UpdateReport(
        string projectId,
        Guid reportId,
        ReportRequest body
    )
    {
        _client.RequestVoid(HttpMethod.Put, $"/projects/{projectId}/reports/{reportId}", body);
    }
}
