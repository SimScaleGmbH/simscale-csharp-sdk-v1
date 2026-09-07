using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Partial model settings applied as an override on top of the state's own model settings. All properties are optional; only those provided are overridden.</summary>
public class ModelSettingsOverride
{
    [JsonPropertyName("scalarField")]
    public ScalarField? ScalarField { get; set; }

    /// <summary>Overrides how the color legend range is scaled for the active scalar (see ScalarSettings.colorLegendScaling): FULL_RA...</summary>
    [JsonPropertyName("colorLegendScaling")]
    public string? ColorLegendScaling { get; set; }

    [JsonPropertyName("outOfRangeColors")]
    public OutOfRangeColorOverride? OutOfRangeColors { get; set; }

}
