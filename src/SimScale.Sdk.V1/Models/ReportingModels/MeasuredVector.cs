using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>A 3-component spatial vector (e.g. a position or a centroid) paired with its length unit.</summary>
public class MeasuredVector
{
    [JsonPropertyName("value")]
    public List<double>? Value { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

}
