using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class Color
{
    [JsonPropertyName("r")]
    [JsonRequired]
    public required double R { get; set; }

    [JsonPropertyName("g")]
    [JsonRequired]
    public required double G { get; set; }

    [JsonPropertyName("b")]
    [JsonRequired]
    public required double B { get; set; }

}
