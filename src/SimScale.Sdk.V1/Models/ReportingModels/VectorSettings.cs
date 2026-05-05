using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class VectorSettings
{
    [JsonPropertyName("vectorField")]
    [JsonRequired]
    public required VectorField VectorField { get; set; }

    [JsonPropertyName("scaleFactor")]
    public double ScaleFactor { get; set; } = 0.2;

    [JsonPropertyName("solidColor")]
    public Color? SolidColor { get; set; }

    [JsonPropertyName("coloring")]
    public string Coloring { get; set; } = "BY_VECTOR_FIELD";

    /// <summary>The minimum length of (non-zero) vectors will be drawn as. Must not be larger than maximumClampingRange. Default valu...</summary>
    [JsonPropertyName("minimumClampingRange")]
    public double? MinimumClampingRange { get; set; }

    /// <summary>The maximum length of (non-zero) vectors will be drawn as. Must not be smaller than minimumClampingRange. Default val...</summary>
    [JsonPropertyName("maximumClampingRange")]
    public double? MaximumClampingRange { get; set; }

    /// <summary>The required minimum length of the vectors in order to be drawn. Must not be larger than maximumFilteringRange. Defau...</summary>
    [JsonPropertyName("minimumFilteringRange")]
    public double? MinimumFilteringRange { get; set; }

    /// <summary>The required maximum length of the vectors in order to be drawn. Must not be smaller than minimumFilteringRange. Defa...</summary>
    [JsonPropertyName("maximumFilteringRange")]
    public double? MaximumFilteringRange { get; set; }

}
