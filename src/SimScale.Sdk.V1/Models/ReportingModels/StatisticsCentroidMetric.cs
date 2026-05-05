using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Centroid [x, y, z] coordinates paired with their length unit.</summary>
public class StatisticsCentroidMetric
{
    /// <summary>The [x, y, z] coordinates of the centroid in model space.</summary>
    [JsonPropertyName("value")]
    public List<double>? Value { get; set; }

    /// <summary>Length unit for the coordinates (e.g. 'm', 'in').</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

}
