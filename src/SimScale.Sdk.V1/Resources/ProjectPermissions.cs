using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class ProjectPermissions
{
    private readonly SimScaleClient _client;

    public ProjectPermissions(SimScaleClient client) => _client = client;

    /// <summary>Get User Project Permissions Get Info about the Permissions that the current requester user has for this Project.</summary>
    public Models.ProjectPermissions GetRequesterProjectPermissions(
        string projectId
    )
    {
        return _client.Request<Models.ProjectPermissions>(HttpMethod.Get, $"/permissions/projects/{projectId}/requester");
    }
}
