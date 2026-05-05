using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class MeshOperations
{
    private readonly SimScaleClient _client;

    public MeshOperations(SimScaleClient client) => _client = client;

    /// <summary>Cancel the mesh operation</summary>
    public void CancelMeshOperation(
        string projectId,
        Guid meshOperationId
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/projects/{projectId}/meshoperations/{meshOperationId}/cancel");
    }

    /// <summary>Check the mesh operation setup</summary>
    public CheckResponse CheckMeshOperationSetup(
        string projectId,
        Guid meshOperationId,
        Guid? simulationId = null
    )
    {
        return _client.Request<CheckResponse>(HttpMethod.Post, $"/projects/{projectId}/meshoperations/{meshOperationId}/check",
            queryParams: new Dictionary<string, object?> { ["simulationId"] = simulationId });
    }

    /// <summary>Create a mesh operation</summary>
    public MeshOperation CreateMeshOperation(
        string projectId,
        MeshOperation body
    )
    {
        return _client.Request<MeshOperation>(HttpMethod.Post, $"/projects/{projectId}/meshoperations", body);
    }

    /// <summary>Estimate the mesh operation</summary>
    public Estimation EstimateMeshOperation(
        string projectId,
        Guid meshOperationId
    )
    {
        return _client.Request<Estimation>(HttpMethod.Post, $"/projects/{projectId}/meshoperations/{meshOperationId}/estimate");
    }

    /// <summary>Get information about the mesh operation</summary>
    public MeshOperation GetMeshOperation(
        string projectId,
        Guid meshOperationId,
        string? meshingSpecSchemaVersion = null
    )
    {
        return _client.Request<MeshOperation>(HttpMethod.Get, $"/projects/{projectId}/meshoperations/{meshOperationId}",
            queryParams: new Dictionary<string, object?> { ["meshingSpecSchemaVersion"] = meshingSpecSchemaVersion });
    }

    /// <summary>Get the mesh operation event log</summary>
    public EventLogResponse GetMeshOperationEventLog(
        string projectId,
        Guid meshOperationId
    )
    {
        return _client.Request<EventLogResponse>(HttpMethod.Get, $"/projects/{projectId}/meshoperations/{meshOperationId}/eventlog");
    }

    /// <summary>List mesh operations for a project</summary>
    public PaginatedResponse<SlimMeshOperation> GetMeshOperations(
        string projectId,
        int? limit = null,
        int? page = null
    )
    {
        return _client.RequestPaginated<SlimMeshOperation>(HttpMethod.Get, $"/projects/{projectId}/meshoperations",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page });
    }

    /// <summary>Start the mesh operation</summary>
    public void StartMeshOperation(
        string projectId,
        Guid meshOperationId,
        Guid? simulationId = null
    )
    {
        _client.RequestVoid(HttpMethod.Post, $"/projects/{projectId}/meshoperations/{meshOperationId}/start",
            queryParams: new Dictionary<string, object?> { ["simulationId"] = simulationId });
    }

    /// <summary>Swap the CAD on which the mesh is based Swap the CAD on which the mesh is based. The assignments on CAD entities are mapped accordingly.</summary>
    public SwapCadReport SwapMeshOperationCad(
        string projectId,
        Guid meshOperationId,
        SwapCadRequest body
    )
    {
        return _client.Request<SwapCadReport>(HttpMethod.Post, $"/projects/{projectId}/meshoperations/{meshOperationId}/swapcad", body);
    }

    /// <summary>Update information about the mesh operation</summary>
    public void UpdateMeshOperation(
        string projectId,
        Guid meshOperationId,
        MeshOperation body
    )
    {
        _client.RequestVoid(HttpMethod.Put, $"/projects/{projectId}/meshoperations/{meshOperationId}", body);
    }
}
