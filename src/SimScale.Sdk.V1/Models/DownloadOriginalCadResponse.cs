using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class DownloadOriginalCadResponse
{
    /// <summary>The temporary url for downloading the the originally imported CAD file.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Expiration timestamp of the URL. Note that this timestamp is not a guarantee, if the url expired prematurely, please...</summary>
    [JsonPropertyName("urlExpiresAt")]
    public string? UrlExpiresAt { get; set; }

}
