using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Length with unit.</summary>
public class Length
{
    /// <summary>Length value.</summary>
    [JsonPropertyName("value")]
    [JsonRequired]
    public required double Value { get; set; }

    /// <summary>Unit of measurement.</summary>
    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
