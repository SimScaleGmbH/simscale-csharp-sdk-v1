using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class Part
{
    /// <summary>The identifier of the part in the result.</summary>
    [JsonPropertyName("partIdentifier")]
    [JsonRequired]
    public required string PartIdentifier { get; set; }

    /// <summary>The identifier of the parent of the part in the result. This value is necessary in cases where multiple parts appear...</summary>
    [JsonPropertyName("parentIdentifier")]
    public string? ParentIdentifier { get; set; }

    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

    [JsonPropertyName("renderMode")]
    public string? RenderMode { get; set; }

    [JsonPropertyName("solidColor")]
    public Color? SolidColor { get; set; }

}
