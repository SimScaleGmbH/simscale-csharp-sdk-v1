using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Bulk statistical values computed for a single part, part group, or cutting plane. Each numeric metric is an object with a 'value' and a 'unit' field. Integral metrics carry composite units; all others carry the plain scalar field unit.</summary>
public class StatisticsResultEntry
{
    [JsonPropertyName("elementMin")]
    public StatisticsMetric? ElementMin { get; set; }

    [JsonPropertyName("elementMax")]
    public StatisticsMetric? ElementMax { get; set; }

    [JsonPropertyName("elementAverage")]
    public StatisticsMetric? ElementAverage { get; set; }

    [JsonPropertyName("elementIntegral")]
    public StatisticsMetric? ElementIntegral { get; set; }

    [JsonPropertyName("elementAreaWeightedAverage")]
    public StatisticsMetric? ElementAreaWeightedAverage { get; set; }

    [JsonPropertyName("nodeAverage")]
    public StatisticsMetric? NodeAverage { get; set; }

    [JsonPropertyName("nodeMin")]
    public StatisticsMetric? NodeMin { get; set; }

    [JsonPropertyName("nodeMax")]
    public StatisticsMetric? NodeMax { get; set; }

    [JsonPropertyName("volumeElementIntegral")]
    public StatisticsMetric? VolumeElementIntegral { get; set; }

    [JsonPropertyName("volumeElementAverage")]
    public StatisticsMetric? VolumeElementAverage { get; set; }

    [JsonPropertyName("volumeElementVolumeAreaWeightedAverage")]
    public StatisticsMetric? VolumeElementVolumeAreaWeightedAverage { get; set; }

    [JsonPropertyName("volumeElementMin")]
    public StatisticsMetric? VolumeElementMin { get; set; }

    [JsonPropertyName("volumeElementMax")]
    public StatisticsMetric? VolumeElementMax { get; set; }

    [JsonPropertyName("centroid")]
    public StatisticsCentroidMetric? Centroid { get; set; }

}
