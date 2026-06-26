using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class StatisticsCuttingPlaneRegionEntry
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

    [JsonPropertyName("boundingBoxMin")]
    public StatisticsCentroidMetric? BoundingBoxMin { get; set; }

    [JsonPropertyName("boundingBoxMax")]
    public StatisticsCentroidMetric? BoundingBoxMax { get; set; }

    /// <summary>The mesh part name the plane intersected to produce this region; null when the part could not be resolved.</summary>
    [JsonPropertyName("partName")]
    public string? PartName { get; set; }

    /// <summary>The user-facing label of the intersected part, resolved from the mesh topology (e.g. "Air domain", "solid1"); null wh...</summary>
    [JsonPropertyName("partLabel")]
    public string? PartLabel { get; set; }

}
