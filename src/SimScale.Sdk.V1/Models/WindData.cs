using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class WindData
{
    /// <summary>The name of the newly created simulation run.</summary>
    [JsonPropertyName("name")]
    [JsonRequired]
    public required string Name { get; set; }

}
