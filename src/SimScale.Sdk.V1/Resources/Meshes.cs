using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class Meshes
{
    private readonly SimScaleClient _client;

    public Meshes(SimScaleClient client) => _client = client;

    /// <summary>Get information about the mesh</summary>
    public Mesh GetMesh(
        string projectId,
        Guid meshId
    )
    {
        return _client.Request<Mesh>(HttpMethod.Get, $"/projects/{projectId}/meshes/{meshId}");
    }

    /// <summary>List meshes within a project Only finished and non-uploaded meshes are included.</summary>
    public PaginatedResponse<Mesh> GetMeshes(
        string projectId,
        int? limit = null,
        int? page = null
    )
    {
        return _client.RequestPaginated<Mesh>(HttpMethod.Get, $"/projects/{projectId}/meshes",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page });
    }
}
