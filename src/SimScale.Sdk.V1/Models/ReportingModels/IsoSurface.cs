using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class IsoSurface
{
    [JsonPropertyName("isoScalar")]
    public ScalarField? IsoScalar { get; set; }

    /// <summary>The iso scalar value. Should be within the selected scalar range. Default value is the average between the min and ma...</summary>
    [JsonPropertyName("isoValue")]
    public double? IsoValue { get; set; }

    [JsonPropertyName("scalarField")]
    public ScalarField? ScalarField { get; set; }

    [JsonPropertyName("solidColor")]
    public Color? SolidColor { get; set; }

    [JsonPropertyName("vectorField")]
    public VectorField? VectorField { get; set; }

    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

}
