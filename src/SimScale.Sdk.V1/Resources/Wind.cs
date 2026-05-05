using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class Wind
{
    private readonly SimScaleClient _client;

    public Wind(SimScaleClient client) => _client = client;

    /// <summary>Get wind condition for given coordinates</summary>
    public WindRoseResponse GetWindData(
        string? latitude = null,
        string? longitude = null
    )
    {
        return _client.Request<WindRoseResponse>(HttpMethod.Get, $"/winddata",
            queryParams: new Dictionary<string, object?> { ["latitude"] = latitude, ["longitude"] = longitude });
    }
}
