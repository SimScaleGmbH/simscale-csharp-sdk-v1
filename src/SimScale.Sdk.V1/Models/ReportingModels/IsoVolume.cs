using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class IsoVolume
{
    [JsonPropertyName("isoScalar")]
    public ScalarField? IsoScalar { get; set; }

    /// <summary>The iso scalar minimum value. Should be within the selected scalar range and smaller than the maximumIsoValue. Defaul...</summary>
    [JsonPropertyName("minimumIsoValue")]
    public double? MinimumIsoValue { get; set; }

    /// <summary>The iso scalar maximum value. Should be within the selected scalar range and larger than the minimumIsoValue. Default...</summary>
    [JsonPropertyName("maximumIsoValue")]
    public double? MaximumIsoValue { get; set; }

    [JsonPropertyName("scalarField")]
    public ScalarField? ScalarField { get; set; }

    [JsonPropertyName("solidColor")]
    public Color? SolidColor { get; set; }

    [JsonPropertyName("vectorField")]
    public VectorField? VectorField { get; set; }

    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

}
