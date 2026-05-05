using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class Storage
{
    private readonly SimScaleClient _client;

    public Storage(SimScaleClient client) => _client = client;

    /// <summary>Create a temporary storage location</summary>
    public Models.Storage CreateStorage()
    {
        return _client.Request<Models.Storage>(HttpMethod.Post, $"/storage");
    }
}
