using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Plane with unit.</summary>
public class Plane
{
    [JsonPropertyName("point")]
    [JsonRequired]
    public required Vector Point { get; set; }

    [JsonPropertyName("normal")]
    [JsonRequired]
    public required Vector Normal { get; set; }

    /// <summary>Unit of measurement.</summary>
    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
