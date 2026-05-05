using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Axis-aligned box.</summary>
public class Box
{
    /// <summary>Min x</summary>
    [JsonPropertyName("minX")]
    [JsonRequired]
    public required double MinX { get; set; }

    /// <summary>Min y</summary>
    [JsonPropertyName("minY")]
    [JsonRequired]
    public required double MinY { get; set; }

    /// <summary>Min z</summary>
    [JsonPropertyName("minZ")]
    [JsonRequired]
    public required double MinZ { get; set; }

    /// <summary>Max x</summary>
    [JsonPropertyName("maxX")]
    [JsonRequired]
    public required double MaxX { get; set; }

    /// <summary>Max y</summary>
    [JsonPropertyName("maxY")]
    [JsonRequired]
    public required double MaxY { get; set; }

    /// <summary>Max z</summary>
    [JsonPropertyName("maxZ")]
    [JsonRequired]
    public required double MaxZ { get; set; }

}
