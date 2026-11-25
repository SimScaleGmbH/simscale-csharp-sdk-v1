using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Hint arrow to be used in the viewer: origin in meters, unit direction.</summary>
public class Arrow
{
    [JsonPropertyName("origin")]
    [JsonRequired]
    public required Vector Origin { get; set; }

    [JsonPropertyName("direction")]
    [JsonRequired]
    public required Vector Direction { get; set; }

}
