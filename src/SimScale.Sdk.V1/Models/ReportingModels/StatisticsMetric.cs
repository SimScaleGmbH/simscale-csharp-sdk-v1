using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>A scalar metric value paired with its unit string.</summary>
public class StatisticsMetric
{
    /// <summary>The numeric value, or null when the value could not be computed.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    /// <summary>Unit string for this metric (e.g. 'm/s', 'Pa', 'Pa·m²'). Integral metrics carry a composite unit (fieldUnit × surface...</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

}
