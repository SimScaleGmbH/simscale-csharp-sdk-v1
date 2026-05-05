using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class Spaces
{
    private readonly SimScaleClient _client;

    public Spaces(SimScaleClient client) => _client = client;

    /// <summary>Get Space Info Get Space metadata, current user permissions, and view Space settings</summary>
    public Space GetSpaceInfo(
        Guid spaceId
    )
    {
        return _client.Request<Space>(HttpMethod.Get, $"/spaces/{spaceId}");
    }

    /// <summary>Get User Spaces Get Info about the User Personal Space and all the Team Spaces the user has access to.</summary>
    public Models.Spaces GetUserSpaces()
    {
        return _client.Request<Models.Spaces>(HttpMethod.Get, $"/spaces");
    }

    /// <summary>Update Space Update Space metadata and settings</summary>
    public Space UpdateSpace(
        Guid spaceId,
        Space body
    )
    {
        return _client.Request<Space>(HttpMethod.Put, $"/spaces/{spaceId}", body);
    }
}
