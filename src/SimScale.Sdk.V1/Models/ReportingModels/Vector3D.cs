using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class Vector3D
{
    [JsonPropertyName("x")]
    [JsonRequired]
    public required double X { get; set; }

    [JsonPropertyName("y")]
    [JsonRequired]
    public required double Y { get; set; }

    [JsonPropertyName("z")]
    [JsonRequired]
    public required double Z { get; set; }

}
