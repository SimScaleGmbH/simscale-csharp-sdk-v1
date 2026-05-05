using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class ScalarSettings
{
    [JsonPropertyName("scalarField")]
    [JsonRequired]
    public required ScalarField ScalarField { get; set; }

    /// <summary>The minimum value for the color scheme to fill. Default is the minimum value of the scalar.</summary>
    [JsonPropertyName("minimumRange")]
    public double? MinimumRange { get; set; }

    /// <summary>The maximum value for the color scheme to fill. Default is the maximum value of the scalar.</summary>
    [JsonPropertyName("maximumRange")]
    public double? MaximumRange { get; set; }

    /// <summary>Specify if the scalar result should be shown as a node averaged result or not.</summary>
    [JsonPropertyName("nodeAverageValue")]
    public bool? NodeAverageValue { get; set; }

    /// <summary>The number of divisions in the legend. If set to 0, this will create a continuous (gradient) legend with a smooth int...</summary>
    [JsonPropertyName("numberOfDivisions")]
    public int? NumberOfDivisions { get; set; }

    /// <summary>The color scheme to use to map scalar values on the model and legend bar.</summary>
    [JsonPropertyName("colorScheme")]
    public string? ColorScheme { get; set; }

}
