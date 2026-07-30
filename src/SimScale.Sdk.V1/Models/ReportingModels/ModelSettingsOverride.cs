using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Partial model settings applied as an override on top of the state's own model settings. All properties are optional; only those provided are overridden.</summary>
public class ModelSettingsOverride
{
    [JsonPropertyName("scalarField")]
    public ScalarField? ScalarField { get; set; }

}
