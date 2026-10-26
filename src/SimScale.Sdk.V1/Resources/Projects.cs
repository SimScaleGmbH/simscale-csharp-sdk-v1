using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class Projects
{
    private readonly SimScaleClient _client;

    public Projects(SimScaleClient client) => _client = client;

    /// <summary>Copy an existing project The copy has the visibility of the source project unless 'visibility' is set.</summary>
    public Project CopyProject(
        string projectId,
        ProjectCopyRequest body
    )
    {
        return _client.Request<Project>(HttpMethod.Post, $"/projects/{projectId}/copy", body);
    }

    /// <summary>Create a new project Set 'visibility' to create a public or a private project. When omitted, users who can create private projects get a private project, all others (for example Community accounts) get a public one. Requesting a private project without a plan that allows it fails with 403.</summary>
    public Project CreateProject(
        Project body
    )
    {
        return _client.Request<Project>(HttpMethod.Post, $"/projects", body);
    }

    /// <summary>Delete an existing project The project is moved to the trash together with its CADs, meshes, simulations and runs. Running jobs are stopped. A trashed project can be restored from the SimScale workbench for a limited time.</summary>
    public void DeleteProject(
        string projectId
    )
    {
        _client.RequestVoid(HttpMethod.Delete, $"/projects/{projectId}");
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
        int? page = null,
        string? projectType = null
    )
    {
        return _client.RequestPaginated<Project>(HttpMethod.Get, $"/projects",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page, ["projectType"] = projectType });
    }

    /// <summary>Update an existing project Set 'visibility' to change between public and private. When omitted, the visibility is kept.</summary>
    public void UpdateProject(
        string projectId,
        Project body
    )
    {
        _client.RequestVoid(HttpMethod.Put, $"/projects/{projectId}", body);
    }
}
