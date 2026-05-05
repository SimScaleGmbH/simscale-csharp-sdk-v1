using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class Projects
{
    private readonly SimScaleClient _client;

    public Projects(SimScaleClient client) => _client = client;

    /// <summary>Copy an existing project</summary>
    public Project CopyProject(
        string projectId,
        ProjectCopyRequest body
    )
    {
        return _client.Request<Project>(HttpMethod.Post, $"/projects/{projectId}/copy", body);
    }

    /// <summary>Create a new project The visibility of the Project will be determined by the available capabilities of the requesting user. If the user can create private projects, the Project will be private. Otherwise, it will be public.</summary>
    public Project CreateProject(
        Project body
    )
    {
        return _client.Request<Project>(HttpMethod.Post, $"/projects", body);
    }

    /// <summary>Get information about an existing project</summary>
    public Project GetProject(
        string projectId
    )
    {
        return _client.Request<Project>(HttpMethod.Get, $"/projects/{projectId}");
    }

    /// <summary>List projects</summary>
    public PaginatedResponse<Project> GetProjects(
        int? limit = null,
        int? page = null
    )
    {
        return _client.RequestPaginated<Project>(HttpMethod.Get, $"/projects",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page });
    }

    /// <summary>Update an existing project</summary>
    public void UpdateProject(
        string projectId,
        Project body
    )
    {
        _client.RequestVoid(HttpMethod.Put, $"/projects/{projectId}", body);
    }
}
