using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Cylinder with unit.</summary>
public class Cylinder
{
    [JsonPropertyName("center")]
    [JsonRequired]
    public required Vector Center { get; set; }

    [JsonPropertyName("axis")]
    [JsonRequired]
    public required Vector Axis { get; set; }

    [JsonPropertyName("radius")]
    [JsonRequired]
    public required double Radius { get; set; }

    [JsonPropertyName("height")]
    [JsonRequired]
    public required double Height { get; set; }

    /// <summary>Unit of measurement.</summary>
    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
