using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>3D vector with unit.</summary>
public class VectorWithUnit
{
    [JsonPropertyName("value")]
    [JsonRequired]
    public required Vector Value { get; set; }

    /// <summary>Unit of measurement.</summary>
    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
