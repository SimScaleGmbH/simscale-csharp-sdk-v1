using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>3D vector.</summary>
public class Vector
{
    /// <summary>X</summary>
    [JsonPropertyName("X")]
    [JsonRequired]
    public required double X { get; set; }

    /// <summary>Y</summary>
    [JsonPropertyName("Y")]
    [JsonRequired]
    public required double Y { get; set; }

    /// <summary>Z</summary>
    [JsonPropertyName("Z")]
    [JsonRequired]
    public required double Z { get; set; }

}
