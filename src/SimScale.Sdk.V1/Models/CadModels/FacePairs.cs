using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class FacePairs
{
    /// <summary>Internal name of the face.</summary>
    [JsonPropertyName("target")]
    [JsonRequired]
    public required string Target { get; set; }

    /// <summary>Internal name of the face.</summary>
    [JsonPropertyName("tool")]
    [JsonRequired]
    public required string Tool { get; set; }

}
