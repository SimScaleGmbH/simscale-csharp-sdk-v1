using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>A scalar quantity paired with its unit string.</summary>
public class MeasuredScalar
{
    /// <summary>The numeric value, or null when it could not be computed.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

}
