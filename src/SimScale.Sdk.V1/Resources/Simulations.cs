using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.GeometryPrimitiveModels;
using SimScale.Sdk.V1.Models.SimulationModels;

namespace SimScale.Sdk.V1.Resources;

public class Simulations
{
    private readonly SimScaleClient _client;

    public Simulations(SimScaleClient client) => _client = client;

    /// <summary>Check the simulation setup</summary>
    public CheckResponse CheckSimulationSetup(
        string projectId,
        Guid simulationId
    )
    {
        return _client.Request<CheckResponse>(HttpMethod.Post, $"/projects/{projectId}/simulations/{simulationId}/check");
    }

    /// <summary>Create a geometry primitive for reference within a Simulation spec</summary>
    public GeometryPrimitiveResponse CreateGeometryPrimitive(
        string projectId,
        GeometryPrimitive body
    )
    {
        return _client.Request<GeometryPrimitiveResponse>(HttpMethod.Post, $"/projects/{projectId}/geometryprimitives", body);
    }

    /// <summary>Create a simulation setup</summary>
    public Simulation CreateSimulation(
        string projectId,
        SimulationSpec body
    )
    {
        return _client.Request<Simulation>(HttpMethod.Post, $"/projects/{projectId}/simulations", body);
    }

    /// <summary>Estimate the simulation setup</summary>
    public Estimation EstimateSimulationSetup(
        string projectId,
        Guid simulationId
    )
    {
        return _client.Request<Estimation>(HttpMethod.Post, $"/projects/{projectId}/simulations/{simulationId}/estimate");
    }

    /// <summary>Get information about the simulation setup</summary>
    public SimulationSpec GetSimulation(
        string projectId,
        Guid simulationId,
        string? simulationSpecSchemaVersion = null
    )
    {
        return _client.Request<SimulationSpec>(HttpMethod.Get, $"/projects/{projectId}/simulations/{simulationId}",
            queryParams: new Dictionary<string, object?> { ["simulationSpecSchemaVersion"] = simulationSpecSchemaVersion });
    }

    /// <summary>List simulation setups within a project</summary>
    public PaginatedResponse<Simulation> GetSimulations(
        string projectId,
        int? limit = null,
        int? page = null
    )
    {
        return _client.RequestPaginated<Simulation>(HttpMethod.Get, $"/projects/{projectId}/simulations",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page });
    }

    /// <summary>Swap the CAD on which the simulation is based Swap the CAD on which the simulation is based. The assignments on CAD entities are mapped accordingly. This operation supports only swap between two CADs.</summary>
    public SwapCadReport SwapSimulationCad(
        string projectId,
        Guid simulationId,
        SwapCadRequest body
    )
    {
        return _client.Request<SwapCadReport>(HttpMethod.Post, $"/projects/{projectId}/simulations/{simulationId}/swapcad", body);
    }

    /// <summary>Update information about the simulation setup</summary>
    public void UpdateSimulation(
        string projectId,
        Guid simulationId,
        SimulationSpec body
    )
    {
        _client.RequestVoid(HttpMethod.Put, $"/projects/{projectId}/simulations/{simulationId}", body);
    }

    /// <summary>Update materials in the simulation setup</summary>
    public MaterialUpdateResponse UpdateSimulationMaterials(
        string projectId,
        Guid simulationId,
        MaterialUpdateRequest body,
        bool? preview = null
    )
    {
        return _client.Request<MaterialUpdateResponse>(HttpMethod.Post, $"/projects/{projectId}/simulations/{simulationId}/materials", body,
            queryParams: new Dictionary<string, object?> { ["preview"] = preview });
    }
}
