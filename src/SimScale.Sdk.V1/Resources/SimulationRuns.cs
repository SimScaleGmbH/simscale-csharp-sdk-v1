using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class SimulationRuns
{
    private readonly SimScaleClient _client;

    public SimulationRuns(SimScaleClient client) => _client = client;

    /// <summary>Add wind data to a simulation run (works only for PWC runs) You can use this endpoint to add wind data to an existing PWC run. This means that for the new run, only the statistical surface solution will be regenerated based on the new wind data, while the individual results of each direction will be kept from the original run. This endpoint is only used to trigger the execution of the new simulation run - before calling this endpoint make sure to update the simulation spec with the new wind data.</summary>
    public SimulationRun AddWindDataToSimulationRun(
        string projectId,
        Guid simulationId,
        Guid runId,
        WindData body
    )
    {
        return _client.Request<SimulationRun>(HttpMethod.Post, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/add-wind-data", body);
    }

    /// <summary>Cancel the simulation run</summary>
    public void CancelSimulationRun(
        string projectId,
        Guid simulationId,
        Guid runId
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/cancel");
    }

    /// <summary>Cancel the sub-run of a parametric run</summary>
    public void CancelSimulationRunSubRun(
        string projectId,
        Guid simulationId,
        Guid runId,
        Guid subRunId
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/subruns/{subRunId}/cancel");
    }

    /// <summary>Create a simulation run This operation creates a run in status `READY`, however the run is not automatically started. The run must be started explicitly using the `POST /projects/{projectId}/simulations/{simulationId}/runs/{runId}/start` endpoint.</summary>
    public SimulationRun CreateSimulationRun(
        string projectId,
        Guid simulationId,
        SimulationRun body
    )
    {
        return _client.Request<SimulationRun>(HttpMethod.Post, $"/projects/{projectId}/simulations/{simulationId}/runs", body);
    }

    /// <summary>Delete the sub-run of a parametric run</summary>
    public void DeleteSimulationRunSubRun(
        string projectId,
        Guid simulationId,
        Guid runId,
        Guid subRunId
    )
    {
        _client.RequestVoid(HttpMethod.Delete, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/subruns/{subRunId}");
    }

    /// <summary>Get basic information about the simulation run</summary>
    public SimulationRun GetSimulationRun(
        string projectId,
        Guid simulationId,
        Guid runId
    )
    {
        return _client.Request<SimulationRun>(HttpMethod.Get, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}");
    }

    /// <summary>Get the simulation run event log</summary>
    public EventLogResponse GetSimulationRunEventLog(
        string projectId,
        Guid simulationId,
        Guid runId
    )
    {
        return _client.Request<EventLogResponse>(HttpMethod.Get, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/eventlog");
    }

    /// <summary>List available results for a simulation runs</summary>
    public PaginatedResponse<OneOfSimulationRunResult> GetSimulationRunResults(
        string projectId,
        Guid simulationId,
        Guid runId,
        int? limit = null,
        int? page = null,
        string? type = null,
        string? category = null,
        string? quantity = null,
        string? name = null,
        string? direction = null
    )
    {
        return _client.RequestPaginated<OneOfSimulationRunResult>(HttpMethod.Get, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/results",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page, ["type"] = type, ["category"] = category, ["quantity"] = quantity, ["name"] = name, ["direction"] = direction });
    }

    /// <summary>Get the simulation run spec</summary>
    public SimulationSpec GetSimulationRunSpec(
        string projectId,
        Guid simulationId,
        Guid runId,
        string? simulationSpecSchemaVersion = null
    )
    {
        return _client.Request<SimulationSpec>(HttpMethod.Get, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/spec",
            queryParams: new Dictionary<string, object?> { ["simulationSpecSchemaVersion"] = simulationSpecSchemaVersion });
    }

    /// <summary>Get the simulation sub-run results</summary>
    public PaginatedResponse<OneOfSimulationRunResult> GetSimulationRunSubRunResults(
        string projectId,
        Guid simulationId,
        Guid runId,
        Guid subRunId,
        int? limit = null,
        int? page = null,
        string? type = null,
        string? category = null,
        string? quantity = null,
        string? name = null
    )
    {
        return _client.RequestPaginated<OneOfSimulationRunResult>(HttpMethod.Get, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/subruns/{subRunId}/results",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page, ["type"] = type, ["category"] = category, ["quantity"] = quantity, ["name"] = name });
    }

    /// <summary>Get the simulation sub-run spec</summary>
    public SimulationSpec GetSimulationRunSubRunSpec(
        string projectId,
        Guid simulationId,
        Guid runId,
        Guid subRunId,
        string? simulationSpecSchemaVersion = null
    )
    {
        return _client.Request<SimulationSpec>(HttpMethod.Get, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/subruns/{subRunId}/spec",
            queryParams: new Dictionary<string, object?> { ["simulationSpecSchemaVersion"] = simulationSpecSchemaVersion });
    }

    /// <summary>List of sub-runs of parametric runs</summary>
    public PaginatedResponse<SimulationRun> GetSimulationRunSubRuns(
        string projectId,
        Guid simulationId,
        Guid runId,
        int? limit = null,
        int? page = null
    )
    {
        return _client.RequestPaginated<SimulationRun>(HttpMethod.Get, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/subruns",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page });
    }

    /// <summary>List simulation runs for a simulation</summary>
    public PaginatedResponse<SimulationRun> GetSimulationRuns(
        string projectId,
        Guid simulationId,
        int? limit = null,
        int? page = null
    )
    {
        return _client.RequestPaginated<SimulationRun>(HttpMethod.Get, $"/projects/{projectId}/simulations/{simulationId}/runs",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page });
    }

    /// <summary>Start the simulation run</summary>
    public void StartSimulationRun(
        string projectId,
        Guid simulationId,
        Guid runId
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}/start");
    }

    /// <summary>Update an existing simulation run</summary>
    public void UpdateSimulationRun(
        string projectId,
        Guid simulationId,
        Guid runId,
        SimulationRun body
    )
    {
        _client.RequestVoid(HttpMethod.Put, $"/projects/{projectId}/simulations/{simulationId}/runs/{runId}", body);
    }
}
