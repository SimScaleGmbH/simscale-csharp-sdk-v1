using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ModelSettings
{
    /// <summary>The parts to show or hide in the report (see hideSelectedParts).</summary>
    [JsonPropertyName("parts")]
    public List<Part>? Parts { get; set; }

    /// <summary>If set to true, the parts array indicates the hidden parts, while the rest of the model parts are visible (blacklist)...</summary>
    [JsonPropertyName("hideSelectedParts")]
    public bool HideSelectedParts { get; set; } = false;

    /// <summary>If set to false, then volumes will be hidden unless they are mentioned explicitly, i.e. when a volume is included in...</summary>
    [JsonPropertyName("showVolumes")]
    public bool? ShowVolumes { get; set; }

    [JsonPropertyName("scalarField")]
    public ScalarField? ScalarField { get; set; }

    [JsonPropertyName("scalarSettings")]
    public List<ScalarSettings>? ScalarSettings { get; set; }

    /// <summary>The settings for the different vectors of the model.</summary>
    [JsonPropertyName("vectorSettings")]
    public List<VectorSettings>? VectorSettings { get; set; }

    [JsonPropertyName("opacity")]
    public double? Opacity { get; set; }

    [JsonPropertyName("renderMode")]
    public string? RenderMode { get; set; }

    [JsonPropertyName("solidColor")]
    public Color? SolidColor { get; set; }

}
