using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.DataRepositoryModels;

/// <summary>Pre-signed HTTP request.</summary>
public class PresignedRequest
{
    [JsonPropertyName("headers")]
    public List<HttpHeader>? Headers { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

}
