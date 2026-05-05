using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MaterialModels;

public class MaterialPropertyParameter
{
    /// <summary>The unique identifier of the parameter, meaningful from the physics/business perspective</summary>
    [JsonPropertyName("key")]
    [JsonRequired]
    public required string Key { get; set; }

    /// <summary>Optional user facing name or label key for human identification</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parameter unit</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

}
