using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class RenameCadRequest
{
    /// <summary>New CAD name.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

}
