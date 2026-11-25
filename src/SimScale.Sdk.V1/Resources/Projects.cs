using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class Projects
{
    private readonly SimScaleClient _client;

    public Projects(SimScaleClient client) => _client = client;

    /// <summary>Copy an existing project Deprecated: large projects can take longer to copy than the request is allowed to run. Start the copy via `POST /projects/{projectId}/copies` and check its status via `GET /projects/{projectId}/copies/{projectCopyId}` instead. Unless 'visibility' is set, the copy is private on a Professional plan and has the visibility of the source project otherwise.</summary>
    public Project CopyProject(
        string projectId,
        ProjectCopyRequest body
    )
    {
        return _client.Request<Project>(HttpMethod.Post, $"/projects/{SimScaleClient.PathSegment(projectId)}/copy", body);
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
        _client.RequestVoid(HttpMethod.Delete, $"/projects/{SimScaleClient.PathSegment(projectId)}");
    }

    /// <summary>Get information about an existing project</summary>
    public Project GetProject(
        string projectId
    )
    {
        return _client.Request<Project>(HttpMethod.Get, $"/projects/{SimScaleClient.PathSegment(projectId)}");
    }

    /// <summary>Get information about the project copy Only the user who started the copy can read it. Finished copies can be read for 7 days.</summary>
    public ProjectCopyResponse GetProjectCopy(
        string projectId,
        Guid projectCopyId
    )
    {
        return _client.Request<ProjectCopyResponse>(HttpMethod.Get, $"/projects/{SimScaleClient.PathSegment(projectId)}/copies/{SimScaleClient.PathSegment(projectCopyId)}");
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

    /// <summary>Start copying an existing project Copying a project requires the following steps: 1. Start the copy via `POST /projects/{projectId}/copies`. 2. Check for the copy status via `GET /projects/{projectId}/copies/{projectCopyId}` until it is `FINISHED` or `FAILED`. 3. Once `FINISHED`, the `projectId` of the response is the ID of the new project. Unless 'visibility' is set, the copy is private on a Professional plan and has the visibility of the source project otherwise.</summary>
    public ProjectCopyResponse StartProjectCopy(
        string projectId,
        ProjectCopyRequest body
    )
    {
        return _client.Request<ProjectCopyResponse>(HttpMethod.Post, $"/projects/{SimScaleClient.PathSegment(projectId)}/copies", body);
    }

    /// <summary>Update an existing project Set 'visibility' to change between public and private. When omitted, the visibility is kept.</summary>
    public void UpdateProject(
        string projectId,
        Project body
    )
    {
        _client.RequestVoid(HttpMethod.Put, $"/projects/{SimScaleClient.PathSegment(projectId)}", body);
    }
}
