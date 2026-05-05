using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class BodyPath
{
    [JsonPropertyName("assembly")]
    public string? Assembly { get; set; }

    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

}
