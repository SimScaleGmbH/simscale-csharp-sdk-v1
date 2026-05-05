using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class Interference
{
    /// <summary>Internal name of the solid region.</summary>
    [JsonPropertyName("target")]
    [JsonRequired]
    public required string Target { get; set; }

    /// <summary>Internal name of the solid region.</summary>
    [JsonPropertyName("tool")]
    [JsonRequired]
    public required string Tool { get; set; }

}
