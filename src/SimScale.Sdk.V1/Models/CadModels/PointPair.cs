using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Hint line in meters to be used in the viewer.</summary>
public class PointPair
{
    [JsonPropertyName("point1")]
    [JsonRequired]
    public required Vector Point1 { get; set; }

    [JsonPropertyName("point2")]
    [JsonRequired]
    public required Vector Point2 { get; set; }

}
