using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

public class MeasuredValue
{
    /// <summary>Information on the result of the measurement.</summary>
    [JsonPropertyName("description")]
    [JsonRequired]
    public required string Description { get; set; }

    /// <summary>Unit of measurement.</summary>
    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

    /// <summary>Value of the measurement in the correct unit.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("vectorValue")]
    public Vector? VectorValue { get; set; }

    [JsonPropertyName("hitLine")]
    public PointPair? HitLine { get; set; }

}
