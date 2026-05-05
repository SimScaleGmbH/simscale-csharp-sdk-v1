using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class SpacePermissions
{
    private readonly SimScaleClient _client;

    public SpacePermissions(SimScaleClient client) => _client = client;

    /// <summary>Get User Space Permissions Get Info about the Permissions that the current requester user has in this Space.</summary>
    public Models.SpacePermissions GetRequesterSpacePermissions(
        Guid spaceId
    )
    {
        return _client.Request<Models.SpacePermissions>(HttpMethod.Get, $"/permissions/spaces/{spaceId}/requester");
    }

    /// <summary>List Space Permissions See who has access to a Space</summary>
    public Permissions ListSpacePermissions(
        Guid spaceId
    )
    {
        return _client.Request<Permissions>(HttpMethod.Get, $"/permissions/spaces/{spaceId}");
    }

    /// <summary>Update Space Permissions Update who has access to a Space.</summary>
    public Permissions UpdateSpacePermissions(
        Guid spaceId,
        Permissions body
    )
    {
        return _client.Request<Permissions>(HttpMethod.Put, $"/permissions/spaces/{spaceId}", body);
    }
}
