using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class StatisticsCentroidMetric
{
    [JsonPropertyName("value")]
    public List<double>? Value { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

}
