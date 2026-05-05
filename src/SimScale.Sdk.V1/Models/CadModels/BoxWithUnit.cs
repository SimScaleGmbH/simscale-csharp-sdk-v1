using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Axis-aligned box with unit.</summary>
public class BoxWithUnit
{
    [JsonPropertyName("box")]
    [JsonRequired]
    public required Box Box { get; set; }

    /// <summary>Unit of measurement.</summary>
    [JsonPropertyName("unit")]
    [JsonRequired]
    public required string Unit { get; set; }

}
