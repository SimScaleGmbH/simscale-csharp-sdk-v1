using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class SeedSettings
{
    [JsonPropertyName("center")]
    [JsonRequired]
    public required Vector3D Center { get; set; }

    [JsonPropertyName("normal")]
    [JsonRequired]
    public required Vector3D Normal { get; set; }

    /// <summary>Number of seed points in the horizontal direction.</summary>
    [JsonPropertyName("horizontalDimension")]
    public int HorizontalDimension { get; set; } = 10;

    /// <summary>Number of seed points in the vertical direction.</summary>
    [JsonPropertyName("verticalDimension")]
    public int VerticalDimension { get; set; } = 10;

    /// <summary>The distance between the seed points. Default is size * 4.</summary>
    [JsonPropertyName("spacing")]
    public double? Spacing { get; set; }

    /// <summary>The radius of the particle trace geometry (cylinder, sphere, comet). Default is the extent of the bounding box of the...</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

}
