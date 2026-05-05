using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ResolutionInfo
{
    [JsonPropertyName("x")]
    [JsonRequired]
    public required int X { get; set; }

    [JsonPropertyName("y")]
    [JsonRequired]
    public required int Y { get; set; }

}
